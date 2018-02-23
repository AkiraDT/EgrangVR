using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform player;
	public Transform cameraPlayer;

	public float speed = 3f;

	private bool moveForward;
	private CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((cameraPlayer.eulerAngles.z >= 15f && cameraPlayer.eulerAngles.z < 90f)
			|| (cameraPlayer.eulerAngles.z <= 345 && cameraPlayer.eulerAngles.z >= 270)) {
			moveForward = true;
		} else {
			moveForward = false;
		}
		Debug.Log (cameraPlayer.eulerAngles.z);

		if (moveForward) {
			Vector3 forward = cameraPlayer.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}
