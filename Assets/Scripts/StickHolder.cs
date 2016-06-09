using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class StickHolder : MonoBehaviour {

	Hand hand;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<RigidHand> ().GetLeapHand ().GrabStrength < 0.2) {
			transform.Find ("palm/stick").gameObject.SetActive (false);
		} else {
			transform.Find ("palm/stick").gameObject.SetActive (true);
		}
	}
		
}
