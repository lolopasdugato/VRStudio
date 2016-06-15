﻿using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class BeatMaker : MonoBehaviour {

	public GameObject kick;

	void UpdateBPM () {
		FingerModel thump = gameObject.GetComponent<RigidHand> ().fingers[0];
		if (gameObject.GetComponent<StickHolder> ().isHeld) {
			if (thump.GetBoneDirection (3).y > 0.7f) {
				kick.GetComponent<AutoKick> ().bpm += 10*Time.deltaTime;
			} else if (thump.GetBoneDirection (3).y > 0.7f) {
				kick.GetComponent<AutoKick> ().bpm -= 10*Time.deltaTime;
			}
		}
	}
}
