using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {

	public int count;
	string message;
	private bool flag = true;
	public GameObject the_aliveworm;
	public GameObject the_deadworm;
	// Use this for initialization
	void Start () {
		Debug.Log("hello from script");

		message = "message";
		Debug.Log ("this is a : " + message);

		count = 2016;
		Debug.Log ("the year is " + count);

		Debug.Log (flag);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right")) {
			Flip ("right");
			transform.Translate (.1f, 0f, 0f);


		} else if (Input.GetKey ("up")) {
			transform.Translate (0f, .1f, 0f);

		} else if (Input.GetKey ("left")) {
			Flip ("left");
			transform.Translate (-.1f, 0f, 0f);
		} else if (Input.GetKey ("down")) {
			transform.Translate (0f, -.1f, 0f);
		}

	}

	public void Flip (string direction) {
		var thescale = transform.localScale;
		if (direction == "right") {
			thescale.x = 1.0f;

		} else {
			thescale.x = -1.0f;

		}
		transform.localScale = thescale;

	}

	public void  OnCollisionEnter (Collision collider)	{
		if (collider.gameObject.name == "worm_alive") {
			Debug.Log ("onCollisionEnter was called");
			the_aliveworm.SetActive (false);
			the_deadworm.SetActive (true);
		} else if (collider.gameObject.name == "launchtree") {
			the_deadworm.SetActive (false);
			the_aliveworm.SetActive (true);
		
		}
	}
}
