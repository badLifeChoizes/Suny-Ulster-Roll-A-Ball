using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	[Tooltip("Set the movement speed of the player")]
	[Range(1,100)]public float moveSpeed;
	//public Text countText;
	//public Text winText;

	//private int count;

	void Start(){

		rb = GetComponent<Rigidbody> ();
		//count = 0;
		//SetCountText ();
		//winText.text = "";
	}

	//called just before performing physics calculates
	//location of physic code
	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * moveSpeed);
	}


	//input parameter other is the collider object that just entered the players collider.
	void OnTriggerEnter(Collider other){

		//Deactive the other object
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			ScoreManager.pickUpCount++;
			//SetCountText ();
		}
	}

	/*
	void SetCountText(){

		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {

			winText.text = "YOU WIN!";
		}
	}
	*/

}
