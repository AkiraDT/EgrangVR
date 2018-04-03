using UnityEngine;
using System.Collections;

public class DrivenRotation : MonoBehaviour
{

	public Transform ARCamTransform;

	void Update()
	{
		float y = ARCamTransform.transform.localRotation.eulerAngles.y;
		float x = transform.localEulerAngles.x;
		float z = transform.localEulerAngles.z;
		transform.localEulerAngles = new Vector3(x, y, z);
	}
}