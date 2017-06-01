using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody ballRigidBody;


	// Use this for initialization
	void Start () {
        ballRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            ballRigidBody.AddForceAtPosition(Vector3.up*2, hit.contacts[0].point);
        }
    }

     void OnCollisionExit(Collision hit)
    {

    }
}
