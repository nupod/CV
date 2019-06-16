using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;
	public GameObject dir;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.F) )
		{
			rb.AddForce(dir.transform.forward * thrust);	
		}
    }
}
