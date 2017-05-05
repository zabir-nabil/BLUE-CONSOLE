using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {
	public Transform playerTransform;
	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () {
	   
		float posX = playerTransform.position.x;
		float posY = playerTransform.position.y;
		float posZ = playerTransform.position.z;

		posZ += 10;

		posY += 10;

		Vector3 newPos = new Vector3 (posX, posY, posZ);
		transform.position = newPos;


		
	}
}
