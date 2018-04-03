using UnityEngine;
using System.Collections;

public class ReadPosition : MonoBehaviour
{

	public Transform t;

	void Update()
	{
		transform.position = new Vector3(t.position.x, t.position.y, t.position.z);
	}
}