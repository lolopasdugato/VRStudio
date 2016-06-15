using UnityEngine;
using System.Collections;

public class Fov : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawFrustum(transform.position, 150.0f, 2.0f, 0.0f, 1.0f);
	}
}
