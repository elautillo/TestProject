using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
	[SerializeField] Transform shootPoint;
	[SerializeField] Camera myCamera;
	[SerializeField] GameObject pointer;
	bool pointing = false;
	float currentZoom;
	float maxZoom;
	float minZoom = 25;

	void Start()
	{
		currentZoom = myCamera.fieldOfView;
		maxZoom = myCamera.fieldOfView;

		pointer.SetActive(false);
	}
	
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			pointing = true;
			pointer.SetActive(true);
		}

		if (Input.GetMouseButtonUp(1))
		{
			pointing = false;
			pointer.SetActive(false);
		}

		if (!pointing)
		{
			currentZoom += 3;
			currentZoom = Mathf.Min(currentZoom, maxZoom);
		}
		else
		{
			currentZoom -= 3;
			currentZoom = Mathf.Max(currentZoom, minZoom);
		}

		myCamera.fieldOfView = currentZoom;
	}

	void OnMouseDown()
	{
		Vector3 forward = shootPoint.forward;

		Ray ray = new Ray(shootPoint.position, forward);

		RaycastHit hitInfo;

		Debug.DrawRay(shootPoint.position, shootPoint.forward, Color.red, 5);

		bool impact = Physics.Raycast(ray, out hitInfo, 25);

		if (impact)
		{
			print(hitInfo.collider.gameObject.name);
		}
		else
		{
			print("AGUA");
		}
	}
}
