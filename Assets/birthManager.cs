using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birthManager : MonoBehaviour
{
	public GameObject birthObj;
	public GameObject dirObj;
	public GameObject prefabObj, clone;

	public float thrust = 200;
	public float delayBetweenGo = 0.2f;
	public int count = 5, currentCount;
	public int layerCount, maxLayerCount = 8, iLayer;
	
	public Rigidbody rb;
	

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.B))
		{
			currentCount = count;
			layerCount = maxLayerCount;
			iLayer = 0;
			while (currentCount > maxLayerCount)
			{
				currentCount = currentCount - maxLayerCount;
				iLayer++;
			}
			StartCoroutine(goPrefab());	
		}
	}

	IEnumerator goPrefab()
	{

		Fire();
		yield return new WaitForSeconds(delayBetweenGo);
		if ((currentCount == 0) && (iLayer > 0))
		{
			currentCount = maxLayerCount;
			iLayer--;
		}
		if (currentCount > 0)
		{
			StartCoroutine(goPrefab());
			currentCount--;
		}
	}

	void Fire()
	{
		GetComponent<UIcount>().AddI();
		clone = Instantiate(prefabObj, birthObj.transform.position, dirObj.transform.rotation);
		clone.layer = 16 - currentCount;
		rb = clone.GetComponent<Rigidbody>();
		rb.AddForce(dirObj.transform.forward * thrust);
	}

/*
	private void Start()
	{
		//GetComponent<UIcount>().AddI();
		//Component UI = GetComponent<UIcount>();
		
	}

	*/
}
