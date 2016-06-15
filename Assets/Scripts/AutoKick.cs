using UnityEngine;
using System.Collections;

public class AutoKick : MonoBehaviour {

	public float bpm { get; set; }

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
	}

	float NextBeat () {
		return Time.time + 60f / bpm;
	}
}
