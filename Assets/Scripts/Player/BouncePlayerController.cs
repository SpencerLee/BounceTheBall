using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlayerController : MonoBehaviour {

    public float moveSpeed = 6f;

    Rigidbody playerRigidBody;
    Vector3 playerMovement;


	// Use this for initialization
	void Start () {
        playerRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Move(h);

    }

    void Move(float h)
    {
        // if player's X coord is not greater than 10.5 and we are not trying to move right OR the player's X coord is not less than -10.5 and we are not trying to move left, move the player
        // TODO: replace hardcoded 10.5 values with values for the left and right side of the background
        if ((!(transform.position.x > 10.5f) && h > 0 ) || (!(transform.position.x < -10.5) && h < 0))
        {
            float move_h = h * moveSpeed * Time.deltaTime;
            playerMovement.x = move_h;
            playerRigidBody.MovePosition(transform.position + playerMovement);
        }
    }
}

