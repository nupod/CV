using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
	public GameObject dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Ray rayDir = Camera.main.ScreenPointToRay(dir.transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	}
}
