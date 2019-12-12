using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {
	public Sprite sprite_idle;
	public Sprite sprite_left;
	public Sprite sprite_right;
	public Sprite sprite_dead;
	public SimpleHealthBar healthBar;
	public int health = 100;
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
			rand = (int)Random.Range (0, 4);
			health -= 5;
			healthBar.UpdateBar(health, 100);
			inc = 0;
		}
		actions ();
	}

	public void actions()
	{
		if (health > 0) {
			inc++;
			if (rand == 0)
				go_right ();
			if (rand == 1)
				go_left ();
			if (rand == 2 || rand == 3)
				idle ();
		} else {
			dead ();
		}
	}

	public void dead()
	{
		this.GetComponent<SpriteRenderer> ().sprite = sprite_dead;
		health = 0;
		transform.Translate (Vector3.zero);
	}

	public void idle()
	{
		this.GetComponent<SpriteRenderer> ().sprite = sprite_idle;
		transform.Translate (Vector3.zero);
	}

	public void go_right()
	{
		this.GetComponent<SpriteRenderer> ().sprite = sprite_right;
		transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
	}

	public void go_left()
	{
		this.GetComponent<SpriteRenderer> ().sprite = sprite_left;
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
