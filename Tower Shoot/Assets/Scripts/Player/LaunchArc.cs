﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaunchArc : MonoBehaviour
{
	public float timeResolution = 0.02f;
	public float maxTime = 10.0f;

	[HideInInspector]
	public Vector3 canonTargetLook;

	LineRenderer lineRenderer;
	float discriminant;

	void Start()
	{
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.enabled = false;
	}

	void Update()
	{
		discriminant = GetComponent<FireProjectileV2>().launchData.discriminant;
		if (discriminant > 0)
		{
			lineRenderer.enabled = true;
			Vector3 velocityVector = GetComponent<FireProjectileV2>().launchData.velocity;

			lineRenderer.positionCount = (int)(maxTime / timeResolution);

			int index = 0;

			Vector3 currentPosition = transform.position - 0.5f * velocityVector * timeResolution;

			for (float t = 0f; t < maxTime; t += timeResolution)
			{
				if(index == 1)
					lineRenderer.SetPosition(index - 1, currentPosition);					
				if(index == 3)
					canonTargetLook = currentPosition;

				lineRenderer.SetPosition(index, currentPosition);

				RaycastHit hit;

				if (Physics.Raycast(currentPosition, velocityVector, out hit, velocityVector.magnitude * timeResolution, 1 << 9))
				{
					lineRenderer.positionCount = index + 2;

					lineRenderer.SetPosition(index + 1, hit.point);

					break;
				}
				currentPosition += velocityVector * timeResolution;
				velocityVector += Physics.gravity * timeResolution;
				index++;
			}
		}
		else lineRenderer.enabled = false;
	}
}