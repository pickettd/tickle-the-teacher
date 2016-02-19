using UnityEngine;
using System.Collections;

public class TickleTheTeacherScript : MonoBehaviour {

	public int amountOfTilt = 5;
	public bool backward = true;

	public void clickMe (GameObject teacherPic) {
		var rotationVector = teacherPic.transform.rotation.eulerAngles;
		
		/*
		Rotation Vector starts at 0, the direction of rotation should change at 25 and 340
		*/
		if ((rotationVector.z > 25)&&(rotationVector.z < 100)) {
			backward = false;
		}
		else if ((rotationVector.z > 230)&&(rotationVector.z < 340)) {
			backward = true;
		}

		if (backward) {
			rotationVector.z += amountOfTilt;
		} 
		else {
			rotationVector.z -= amountOfTilt;
		}
		
		teacherPic.transform.rotation = Quaternion.Euler(rotationVector);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
