using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int pickUpCount; 
	public Text winText;
	public Text countText;

	void Awake()
	{
		//set yp the reference
		countText = GetComponent<Text>();
		winText.text = "";
		//Reset the score
		pickUpCount = 0;
	}

	void Update()
	{
		//set the displayed text to score value
		countText.text = "Count: " + pickUpCount.ToString();
		if (pickUpCount >= 12) {

			winText.text = "YOU WIN!";
		}
	}
}
