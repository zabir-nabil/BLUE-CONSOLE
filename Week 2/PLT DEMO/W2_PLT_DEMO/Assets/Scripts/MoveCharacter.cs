using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

	public CharacterController playerControl;
	// Use this for initialization
	public float maxSpeed = 1f;
	public Vector3 speedVector;
	void Start () {
		speedVector = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

		
		gameObject.GetComponent<Renderer>().material.color = Color.magenta;
		

		float playerInputX = Input.GetAxis("Horizontal");
		float playerInputZ = Input.GetAxis("Vertical");

		speedVector.x = playerInputX*maxSpeed;
		speedVector.z = playerInputZ*maxSpeed;

		Vector3 pos = transform.position;

		pos += speedVector;

		transform.position = pos;

		//playerControl.SimpleMove (speedVector);
	}
}
