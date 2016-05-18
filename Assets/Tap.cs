using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour
{

    Material mat;

    // Use this for initialization
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mat.color = Color.green;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("bone"))
            mat.color = Color.blue;
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name.Contains("bone"))
            mat.color = Color.red;
    }
}
