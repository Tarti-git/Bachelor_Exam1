using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {
	int movementSpeed = 100;
	public int rand;
	public int inc = 0;
	// Use this for initialization
	void Start () {
		//InvokeRepeating ("actions", 0, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (inc == 200) {
			rand = (int)Random.Range (0, 3);
			inc = 0;
		}
		actions ();
	}

	public void actions()
	{
		inc++;
		if (rand == 0)
			go_right ();
		if (rand == 1)
			go_left ();
		if (rand == 2)
			idle ();
	}

	public void idle()
	{
		transform.Translate (Vector3.zero);
	}

	public void go_right()
	{
		transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
	}

	public void go_left()
	{
		transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
	}

	public void switch_on()
	{
		if (GetComponent<IA>().enabled == true)
			GetComponent<IA>().enabled = false;
		else
			GetComponent<IA>().enabled = true;
	}
}
