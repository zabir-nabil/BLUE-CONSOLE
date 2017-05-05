using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public Transform playerTransform;
	float colorR,colorG,colorB;
	void Start () {
		colorR = 0.5f;
		colorG = 1.0f;
		colorB = 0.3f;
	}

	void onTriggerEnter(Collider playerCol)
	{

	}
	
	// Update is called once per frame
	void Update () {



		gameObject.GetComponent<Renderer>().material.color = new Color(colorR,colorG,colorB);

		if (Mathf.Abs(playerTransform.position.x - transform.position.x) <= 0.5
		    && Mathf.Abs(playerTransform.position.y - transform.position.y) <= 0.5
		    && Mathf.Abs(playerTransform.position.z - transform.position.z) <= 0.5
		    ) {

			float randX = transform.position.x - Random.Range (-10.0f, 10.0f);
			float randZ = transform.position.z - Random.Range (-10.0f, 10.0f);
			float fixedY = transform.position.y;
			transform.position = new Vector3 (randX, fixedY, randZ);
			colorR = Random.Range(0.0f,1.0f);
			colorG = Random.Range(0.0f,1.0f);
			colorB = Random.Range(0.0f,1.0f);

		}
	}
}
