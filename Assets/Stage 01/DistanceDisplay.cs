using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceDisplay : MonoBehaviour
{
	public Transform object1;
	public Transform object2;
	public TMP_Text textDisplay;
	public static float distance = 20;

	void Update()
	{
		if (object1 != null && object2 != null)
		{
			distance = Vector3.Distance(object1.position, object2.position);
			textDisplay.text = $"Distance between {object1.name} and {object2.name}: {distance} meters";

		}
		else
		{
			Debug.LogError("Please assign both objects in the inspector.");
		}
	}
}
