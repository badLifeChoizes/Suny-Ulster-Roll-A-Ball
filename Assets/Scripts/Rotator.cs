using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	[Tooltip("Set the value of eulerAngle.x degrees applied around the x axis")]
	[Range(-360,360)]public float xValue;
	[Tooltip("Set the value of eulerAngle.y degrees applied around the y axis")]
	[Range(-360,360)]public float yValue;
	[Tooltip("Set the value of eulerAngle.z degrees applied around the z axis")]
	[Range(-360,360)]public float zValue;
	[Tooltip("If isWorldSpace is checked then set rotation relative to world space if unchecked set relative to object")]
	public bool isWorldSpace = false;


	void Update(){

		if (isWorldSpace) {
			transform.Rotate (new Vector3 (xValue, yValue, zValue) * Time.deltaTime, Space.World);
		} else {
			transform.Rotate (new Vector3 (xValue, yValue, zValue) * Time.deltaTime);
		}

	}
}
