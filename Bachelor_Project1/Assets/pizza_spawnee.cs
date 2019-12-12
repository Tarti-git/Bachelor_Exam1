using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza_spawnee : MonoBehaviour {

	public IA data;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "hiwani") {
			data.health += 5;
			data.healthBar.UpdateBar(data.health, 100);
			Destroy (this.gameObject);
		}
	}

}
