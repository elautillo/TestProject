using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
	[SerializeField] Transform genPoint;
	[SerializeField] GameObject prefabProjectile;
	[SerializeField] int force = 2000;

	void Start()
	{
		
	}

	void Update()
	{
		
	}

	void OnMouseDown()
	{
		GameObject projectile = Instantiate(
			prefabProjectile,
			genPoint.transform.position,
			genPoint.transform.rotation);

		projectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
	}
}
