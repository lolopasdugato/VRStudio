using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class BeatMaker : MonoBehaviour {

	float bpm;

	float nextBeat;

	AudioSource src;

	// Use this for initialization
	void Start () {
		bpm = 80;
		src = GetComponent<AudioSource>();
		nextBeat = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextBeat) {
			nextBeat = NextBeat ();
			src.Play ();
		}
		UpdateBPM ();
	}

	float NextBeat () {
		return Time.time + 60f / bpm;
	}

	void UpdateBPM () {
		RigidFinger thump = gameObject.GetComponent<RigidFinger> ();
		if (thump.GetBoneDirection (3).y > 0.7f) {
			bpm += 10*Time.deltaTime;
		} else if (thump.GetBoneDirection (3).y < -0.7f) {
			bpm -= 10*Time.deltaTime;
		}
	}
}
