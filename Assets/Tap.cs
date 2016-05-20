using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour
{

    AudioSource src;

    // Use this for initialization
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("bone"))
            src.Play();
    }
}
