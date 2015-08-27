using UnityEngine;
using System.Collections;

public class FrameRate : MonoBehaviour {

	public int frameRate;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = this.frameRate;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
