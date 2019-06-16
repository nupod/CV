using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
	 
	public Vector3 currentPosition, deltaPosition, lastPosition;
	public float speed;
	// Start is called before the first frame update
	void Start()
    {
		transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.R))
		{
			transform.rotation = Quaternion.identity;
		}
		currentPosition = Input.mousePosition;
		deltaPosition = currentPosition - lastPosition;
		lastPosition = currentPosition;

		transform.Rotate(0, deltaPosition.x * Time.deltaTime*speed, 0);
	}
}
