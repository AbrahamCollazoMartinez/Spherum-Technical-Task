using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpheresHidder : MonoBehaviour
{

	public static Action<bool> enableSpheres = delegate { };

	bool isHide = true;
	bool isTryingChangeScene = false;

	private void Start()
	{
		enableSpheres?.Invoke(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (DistanceDisplay.distance > 2)
		{
			if (!isHide)
			{
				isHide = true;

				enableSpheres?.Invoke(false);


			}
		}
		if (DistanceDisplay.distance > 1 && DistanceDisplay.distance < 2)
		{
			if (isHide)
			{
				isHide = false;
				enableSpheres?.Invoke(true);

			}
		}
		if (DistanceDisplay.distance < 1)
		{
			if (!isTryingChangeScene)
			{
				isTryingChangeScene = true;

				SceneManager.LoadScene("Stage 02");

			}
		}
	}
}
