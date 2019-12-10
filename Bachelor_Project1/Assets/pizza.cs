using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour {
	
	public OpenCVForUnityExample.HandPoseEstimationExample handpose;
	public bool handler_on;
	public int nbfingers = 0;
	public int incant = 0;
	public GameObject spawnee;
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
			if (handpose.numberOfFingers == 5) {
				incant++;
			}
			if (incant >= 25) {
				Instantiate (spawnee, tmppos, Quaternion.identity);
				CancelInvoke ();
				incant = 0;
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
