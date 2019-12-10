using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public OpenCVForUnityExample.HandPoseEstimationExample handpose;
	public double posx = 0;
	public double posy = 0;
	public int nbfingers = 0;
	public bool take;
	public bool handler_on;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (handler_on == true && handpose.detection_on == true) {
			Vector3 tmppos = transform.position;
			tmppos.x = (float)handpose.objpoint.x - 450;
			tmppos.y = -((float)handpose.objpoint.y - 450);
			nbfingers = handpose.numberOfFingers;
			if (nbfingers > 3)
				take = true;
			else
				take = false;
			if (take == true) {
				transform.position = tmppos;
			}
		}
	}

	public void switch_handler()
	{
		if (handler_on == false)
			handler_on = true;
		else
			handler_on = false;
	}
}
