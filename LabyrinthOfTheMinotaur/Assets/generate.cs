using UnityEngine;
using System.Collections;

public class generate : MonoBehaviour {
	public Material mt;
	public Material twoWalls;
	public GameObject wall;
	public int f;
	private int t = 0;
	private GameObject Player;
	private test _WC;
	private Camera g2;
	public Camera g3;
	public ParticleSystem ps1;
	public ParticleSystem ps2;
	public ParticleSystem ps3;
	public ParticleSystem ps4;
	public ParticleSystem ps5;
	public ParticleSystem ps6;
	public ParticleSystem ps7;
	public ParticleSystem ps8;
	public ParticleSystem ps9;
	public ParticleSystem ps10;
	public ParticleSystem ps11;
	public ParticleSystem ps12;
	public ParticleSystem ps13;
	public ParticleSystem ps14;
	public ParticleSystem ps15;
	public ParticleSystem ps16;
	public ParticleSystem ps17;
	public ParticleSystem ps18;
	public ParticleSystem ps19;
	public ParticleSystem ps20;
	public ParticleSystem ps21;
	public ParticleSystem ps22;
	public ParticleSystem ps23;
	public ParticleSystem ps24;
	// Use this for initialization
	void Start () {
		g2 = Camera.main;
		_WC = gameObject.GetComponent<test>();
		int i = 0;
		int u = 0;
		float a = 0;
		float b = 0;
		int j = 0;
		for (i = 0; i < f; i++) {
			for (j = 0; j < f; j++) {
				u++;
				a = i;
				b = j;
				GameObject gm2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				gm2.transform.position = new Vector3 (a, 0f, b);
				gm2.GetComponent<MeshRenderer> ().material = mt;
				gm2.AddComponent<test>();
				gm2.name = "cube" + u.ToString();
				//Instantiate(wall,new Vector3(a,0f,b),Quaternion.identity);
			}
		}
		float f1 = f+1;
		GameObject gm3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gm3.transform.position = new Vector3 (14.5f,0.5f,-1.0f);
		gm3.transform.localScale = new Vector3 (f1+1,15f,1f);
		gm3.GetComponent<MeshRenderer> ().material = twoWalls;
		GameObject gm4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gm4.transform.position = new Vector3 (-1.0f,0.5f,15f);
		gm4.transform.localScale = new Vector3 (1f,15f,f1);
		gm4.GetComponent<MeshRenderer> ().material = twoWalls;
		GameObject gm5 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gm5.transform.position = new Vector3 (30.0f,0.5f,17f);
		gm5.transform.localScale = new Vector3 (1f,15f,25f);
		gm5.GetComponent<MeshRenderer> ().material = twoWalls;
		GameObject gm6 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gm6.transform.position = new Vector3 (15f,0.5f,30f);
		gm6.transform.localScale = new Vector3 (f1,15f,1f);
		gm6.GetComponent<MeshRenderer> ().material = twoWalls;
		GameObject gm7 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gm7.transform.position = new Vector3 (30.0f,0.5f,1f);
		gm7.transform.localScale = new Vector3 (1f,15f,3f);
		gm7.GetComponent<MeshRenderer> ().material = twoWalls;
		ps1.Play ();
		ps2.Play ();
		ps3.Play ();
		ps4.Play ();
		ps5.Play ();
		ps6.Play ();
		ps7.Play ();
		ps8.Play ();
		ps9.Play ();
		ps10.Play ();
		ps11.Play ();
		ps12.Play ();
		ps13.Play ();
		ps14.Play ();
		ps15.Play ();
		ps16.Play ();
		ps17.Play ();
		ps18.Play ();
		ps19.Play ();
		ps20.Play ();
		ps21.Play ();
		ps22.Play ();
		ps23.Play ();
		ps24.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape) == true)
			Application.LoadLevel(0);
		Player = GameObject.FindGameObjectWithTag ("Player");
		if (Player.transform.position.y < -5)
			Application.LoadLevel(3);
		Player = GameObject.FindGameObjectWithTag ("Player");
		if (Player.transform.position.x > 30)
			Application.LoadLevel(4);
		t++;
		if (t%500 == 495){	
			Player.GetComponent<Rigidbody> ().mass = 10000;
			g3.enabled = false;
			g2.enabled = true;
			//_WC.testSetWall (p);
		}
		if (t%500 == 75){
			Player.GetComponent<Rigidbody> ().mass = 1;
			g2.enabled = false;
			g3.enabled = true;
		}
	}
}
