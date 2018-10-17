using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
	[SerializeField] int countdown = 3;
	[SerializeField] int radius = 6;
	[SerializeField] int explosion = 1000;
	[SerializeField] int height = 0;

	void Start()
	{
		Invoke("Explode", countdown);
	}
	
	void Update()
	{
		
	}

	void Explode()
	{
		Collider[] things = Physics.OverlapSphere(transform.position, radius);

		foreach (var thing in things)
		{
			if (thing.gameObject.CompareTag("Explodables"))
			{
				thing.gameObject.GetComponent<Rigidbody>().AddExplosionForce
				(
					explosion,
					this.transform.position,
					radius,
					height
				);
			}
		}
	}
}
