using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
	void Start()
	{
		

	}
	
	void Update()
	{
		
	}

	void OnTriggerEnter(Collider collider)
	{
		gameObject.GetComponent<Rigidbody>().isKinematic = true;
		//gameObject.transform.SetParent

	}
}
