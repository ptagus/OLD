using UnityEngine;
using System.Collections;

public class wallchange : MonoBehaviour {
	private GameObject gm1;
	private Vector3 testvec;

	// Use this for initialization
	void Start () {
		//gm1 = gameObject.this;
	
	}
	public void change (Vector3 _v){
		if (gm1.transform.position == _v)
			testvec = _v;
	}
	// Update is called once per frame
	void Update () {
		gm1.transform.position = Vector3.Lerp (gm1.transform.position,testvec,Time.deltaTime*5);
	
	}
}
