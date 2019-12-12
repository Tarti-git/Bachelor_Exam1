using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public OpenCVForUnityExample.HandPoseEstimationExample handpose;
	public GameObject collisioner;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tmppos = transform.position;
		tmppos.x = (float)handpose.objpoint.x - 800;
		tmppos.y = -((float)handpose.objpoint.y - 200);
		collisioner.transform.position = tmppos;
	}

	public void switch_on()
	{
		if (GetComponent<ball> ().enabled == true) {
			GetComponent<ball> ().enabled = false;
		} else {
			GetComponent<ball> ().enabled = true;
			Vector3 tmppos;
			tmppos.x = -3;
			tmppos.y = 323;
			tmppos.z = 0;
			transform.position = tmppos;
		}
	}
}
