using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour {
	
	public OpenCVForUnityExample.HandPoseEstimationExample handpose;
	public int nbfingers = 0;
	public int incant = 0;
	public GameObject spawnee;
	public Transform papa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			Vector3 tmppos = transform.position;
			tmppos.x = (float)handpose.objpoint.x - 450;
			tmppos.y = -((float)handpose.objpoint.y - 450);
			nbfingers = handpose.numberOfFingers;
			if (nbfingers == 5) {
				incant++;
			}
			if (incant >= 10) {
				GameObject pizza = Instantiate (spawnee, tmppos, Quaternion.identity, papa);
				incant = 0;
				Destroy (pizza, 20f);
			}
	}

	public void switch_on()
	{
		if (GetComponent<pizza>().enabled == true)
			GetComponent<pizza>().enabled = false;
		else
			GetComponent<pizza>().enabled = true;
	}
}
