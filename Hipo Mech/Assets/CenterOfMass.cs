using UnityEngine;
using System.Collections;

public class CenterOfMass : MonoBehaviour {

	public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		this.rigidBody.centerOfMass = this.transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		this.rigidBody.centerOfMass = this.transform.localPosition;
	}
}
