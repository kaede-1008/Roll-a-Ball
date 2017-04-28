using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
	void OnTriggerEnter ( Collider hit)
	{
		if (hit.CompareTag ("Player")) {
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
