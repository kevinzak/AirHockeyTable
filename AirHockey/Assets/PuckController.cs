using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c)
	{
		// force is how forcefully we will push the player away from the enemy.
		float force = 10;

		// If the object we hit is the enemy
			// Calculate Angle Between the collision point and the player
			Vector3 dir = c.contacts[0].point - transform.position;
			// We then get the opposite (-Vector3) and normalize it
			dir = -dir.normalized;
			// And finally we add force in the direction of dir and multiply it by force. 
			// This will push back the player
			GetComponent<Rigidbody>().AddForce(dir*force);
	}

}
