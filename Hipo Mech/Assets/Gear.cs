using UnityEngine;
using System.Collections;

public class Gear : MonoBehaviour {

	public float speed = 0;
	public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(Vector3.back * Time.deltaTime * speed);
		rigidBody.AddTorque (-speed);
	}
}
