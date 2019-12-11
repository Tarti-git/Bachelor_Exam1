using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public OpenCVForUnityExample.HandPoseEstimationExample handpose;
	public int nbfingers = 0;
	public bool take;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			Vector3 tmppos = transform.position;
			tmppos.x = (float)handpose.objpoint.x - 600;
			tmppos.y = -((float)handpose.objpoint.y - 600);
			nbfingers = handpose.numberOfFingers;
			if (nbfingers > 3)
				take = true;
			else
				take = false;
			if (take == true) {
				transform.position = tmppos;
			}
	}

	public void switch_on()
	{
		if (GetComponent<movement>().enabled == true)
			GetComponent<movement>().enabled = false;
		else
			GetComponent<movement>().enabled = true;
	}
}
