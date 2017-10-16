using UnityEngine;
using System.Collections;

public class Myscript : MonoBehaviour {
	public GameObject M2;
	private Transform M3;
	private Transform _thisTransform;
	// Use this for initialization
	void Start () {
		M2 = GameObject.FindGameObjectWithTag ("Player");
		M3 = M2.transform;
	}
	
	// Update is called once per frame
	void Update () {		
		if(transform.position!=M2.transform.position) {
			M2 = GameObject.FindGameObjectWithTag ("Player");
			this.gameObject.transform.LookAt(M3);
			this.gameObject.transform.position = new Vector3(Mathf.Lerp(transform.position.x, M2.transform.position.x, 0.025f*Time.deltaTime), M2.transform.position.y, Mathf.Lerp(transform.position.z, M2.transform.position.z, 0.025f*Time.deltaTime));
		}
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.rigidbody == true){
		//ContactPoint contact = collision.contacts[0];
			Application.LoadLevel(3);}
	}
}
