using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScoreManager : MonoBehaviour {

	public static int billiardCount; 
	public static int pickUpCount; 
	public Text winText;
	public Text countText;

	void Awake()
	{
		//set yp the reference
		countText = GetComponent<Text>();

		//Reset the score
		billiardCount = 0;
	}

	void Update()
	{
		//set the displayed text to score value
		countText.text = "Count: " + billiardCount.ToString();
		if (billiardCount >= 15) {

			winText.text = "YOU WIN!";
		}
	}
}