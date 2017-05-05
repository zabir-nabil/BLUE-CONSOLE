using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public CharacterController PlayerController;
	public Transform cameraTransform;

	// Use this for initialization
	Vector3 motionVector;
	float xScale;
	float zScale;
	float colorR,colorG,colorB;

	void Start () {
		motionVector = new Vector3 (0, 0, 0);
		xScale = -5f;
		zScale = -5f;

		colorR = 1.0f;
		colorG = 0.2f;
		colorB = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {

		
		
		gameObject.GetComponent<Renderer>().material.color = new Color(colorR,colorG,colorB);
		

	   
		float inputX = Input.GetAxis("Horizontal")*(xScale);
		float inputZ = Input.GetAxis("Vertical")*(zScale);

		bool inputJump = Input.GetKeyDown("space");




		motionVector.x = inputX*Time.deltaTime;
		motionVector.z = inputZ*Time.deltaTime;

		//Gravity
		motionVector.y = (PlayerController.velocity.y -9.8f)*Time.deltaTime;

		if (inputJump) {
			
			motionVector.y += 50f*Time.deltaTime;
			print("Down");
			
		}

		colorR = Random.Range(0.0f,1.0f);
		colorG = Random.Range(0.0f,1.0f);
		colorB = Random.Range(0.0f,1.0f);


		//motionVector *= Time.deltaTime;

		//motionVector = cameraTransform.rotation*motionVector;


		PlayerController.Move (motionVector);


	}
}
