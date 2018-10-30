using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 10; //The default speed for the player

    public Rigidbody2D playerFrame; //reference to the rigid body (collidable) around the player

	// Use this for initialization
	void Start () {
        playerFrame = this.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Input.gyro.enabled = true;
        //float initialOrientationX = Input.gyro.rotationRateUnbiased.x;
        //transform.position = new Vector2(0.0f, 0.0f);
        //MovePlayer(initialOrientationX);
    }

    public void MovePlayer(float initialOrientationX)
    {
        //Controls
        //playerFrame.AddForce (initialOrientationX * moveSpeed, 0.0f);

        //Animations???

        //Physics
    }

    public void Shoot()
    {
        //Shooting code
    }
}
