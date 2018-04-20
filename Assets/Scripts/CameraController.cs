using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Takes the current poistion of the player and the 
/// </summary>
public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start(){
		//current position of camera - current position of the player
		offset = transform.position - player.transform.position;
	}

	//For follow cameras, procedural animation, and last known states it is best to use LateUpdate
	//because it does not update until all other items have first been processed.
	void LateUpdate(){
		//set the cameras position to the players position + an offset
		transform.position = player.transform.position + offset;
	}


}

