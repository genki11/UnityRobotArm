using UnityEngine;
using System.Collections;

public class Arm : MonoBehaviour {
	private GameObject MoobArm;
	public const int SPEED = 5;

	// Use this for initialization
	void Start () {
		//MoobArm = GameObject.Find ("MoobArm");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {   
			//transform.Translate (0, 0, 1);
			transform.Translate (transform.forward * 0.1f);
		}

	}
}
