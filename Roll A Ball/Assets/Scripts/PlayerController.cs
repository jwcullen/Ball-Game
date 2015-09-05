using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//PUBLIC VARIABLES
	public float speed;         //The maximum speed the player can travel
	private Rigidbody rb;       //Reference to the RigidBody Component
	
	// Use this for initialization
	void Start () {
		// Get the reference for the RigidBody attached to Player
		rb = GetComponent<Rigidbody>();
	}
	
	// Fixed update used for Physics
	void FixedUpdate () {
		
		// the amount we get from the horizontal axis. 
		// Can be joystick or keyboard
		float moveHorizontal = Input.GetAxis("Horizontal");
		// Same as horizontal but on the vertical axis.
		float moveVertical = Input.GetAxis("Vertical");
		
		// Vector3 variable to use for add force. 
		// Essentially the direction the player will move
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		
		// Adding force to the rigid body in the direction of movement,
		// scaled by speed
		rb.AddForce(movement * speed);
	}
}
