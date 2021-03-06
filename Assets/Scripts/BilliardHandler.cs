using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BilliardHandler : MonoBehaviour {

	public Rigidbody rb;

	public Text countText;
	public Text winText;

	private int billiardCount;

	void Start(){

		rb = GetComponent<Rigidbody> ();
		billiardCount = 0;
		//SetCountText ();
		winText.text = "";
	}

	//input parameter other is the collider object that just entered the players collider.
	void OnTriggerEnter(Collider other){

		//Deactive the other object
		if (other.gameObject.CompareTag ("Billiard")) {
			other.gameObject.SetActive (false);
			BScoreManager.billiardCount++;
		}
	}

	/*
	void SetCountText(){

		countText.text = "Count: " + count.ToString ();
		if (count >= 15) {

			winText.text = "YOU WIN!";
		}
	}
	*/
}
