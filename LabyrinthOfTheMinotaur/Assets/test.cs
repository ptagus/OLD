using UnityEngine;
using System.Collections;

public class Wall {
	private int isWall = 0;

	public int getWall()
	{
		//Debug.Log ("Wall:" + isWall);
		return this.isWall;
	}

	public void setWall(int wall)
	{
		//Debug.Log ("Old Wall:" + isWall);
		this.isWall = wall;
		//Debug.Log ("New Wall:" + isWall);
	}

	public void moveWall (GameObject obj)
	{
		if (isWall < 44) {
			obj.transform.position = Vector3.Slerp (obj.transform.position, new Vector3 (obj.transform.position.x, 1f, obj.transform.position.z), Time.deltaTime*6/5);
		} else 
		{
			obj.transform.position = Vector3.Slerp (obj.transform.position, new Vector3 (obj.transform.position.x, 0f, obj.transform.position.z), Time.deltaTime*6/5);
		}
	}
}

public class test : MonoBehaviour {
	private int f = 30;
	private int i8,i9 = 0;
	private int p,p1,p2=0; 
	private int[] y = new int[9];
	private string[] Str = new string[9];
	private string[] Str1 = new string[4];
	private GameObject g;
	private GameObject g1;
	private GameObject Player;
	Wall OB = new Wall ();

	// Use this for initialization
	void Start () {		
			OB.setWall (Random.Range(90,90));
	}
	
	// Update is called once per frame
	void Update () {
	i8++;
	if (i8 % 500 == 3) {
			Player = GameObject.FindGameObjectWithTag ("Player");
			p1 = Mathf.RoundToInt(Player.transform.position.x);
			p2 = Mathf.RoundToInt (Player.transform.position.z);
			p = p1 * f + p2;
			Str1 [0] = "cube3";
			Str1 [1] = "cube"+f;
			i9 = f * (f - 1) - 5;
			Str1 [2] = "cube"+i9;
			i9 = f * f - 5;
			Str1 [3] = "cube"+i9;
			cubs (p);
			if (g.name == Str1[0] | g.name == Str1[1] | g.name == Str1[2] | g.name == Str[3] | g.name == Str[0] | g.name == Str[1] | g.name == Str[2] | g.name == Str[3] | g.name == Str[4] | g.name == Str[5] | g.name == Str[6] | g.name == Str[7] | g.name == Str[8])
				Debug.Log (g.name);
				else
		OB.setWall (Random.Range(1, 100));
	}
	g = this.gameObject;
	OB.moveWall (g);
	}

	void cubs(int k){
		y [0] = k+1;
		y [1] = y[0] + 1;
		y [2] = y[0] - 1;
		y [3] = y[0] + f +1;
		y [4] = y[0] + f;
		y [5] = y[0] + f -1;
		y [6] = y[0] - f +1;
		y [7] = y[0] - f;
		y [8] = y[0] - f -1;
		Str[0] = "cube"+y[0];
		for (int r = 1; r < 9; r++)
			if (y [r] > f*f | y [r] < 0) {
				y [r] = y [0];
				Str [r] = "cube" + y [r];
				//Debug.Log ("position" + Str [r]);
			} else {
				Str [r] = "cube" + y [r];
				//Debug.Log ("position" + Str [r]);
			}
		
	}
}
