using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class StickHolder : MonoBehaviour {

	Hand hand;

	public float grabStrengthOn = 0.1f;
	public float grabStrengthOff = 0.2f;
	public float grabOffTimer = 1.0f;
	float count = 0.0f;

	public bool isHeld { get; private set; }
	
	// Update is called once per frame
	void Update ()
	{
		print (gameObject.GetComponent<RigidHand> ().GetLeapHand ().GrabStrength);
		if (transform.Find ("palm/stick").gameObject.activeSelf)
		{
            if (gameObject.GetComponent<RigidHand> ().GetLeapHand().GrabStrength < grabStrengthOff)
            {
                count += Time.deltaTime;
                if (count >= grabOffTimer)
                {
                    count = 0.0f;
                    transform.Find("palm/stick").gameObject.SetActive(false);
					isHeld = false;
                }
            }
            else
            {
                count = 0.0f;
            }
		}
		else if (gameObject.GetComponent<RigidHand>().GetLeapHand().GrabStrength >= grabStrengthOn)
		{
			transform.Find("palm/stick").gameObject.SetActive(true);
			isHeld = true;
		}
	}		
}
