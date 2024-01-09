using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
	bool eventSubscribed = false;

	private void OnEnable()
	{
		if (!eventSubscribed)
			SpheresHidder.enableSpheres += SetStateObject;
	}

	private void OnDestroy()
	{
		SpheresHidder.enableSpheres -= SetStateObject;
		eventSubscribed = false;
	}

	private void SetStateObject(bool state)
	{
		this.gameObject.SetActive(state);
	}
}
