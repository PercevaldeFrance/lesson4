using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{	
	public string TriggerName = "IsOpen";
	public GameObject doorObject;

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			doorObject.GetComponent<Animator>().SetTrigger(TriggerName);			
		}
	}
}
