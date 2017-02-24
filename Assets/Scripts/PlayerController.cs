using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public enum FACE_DIRECTION
	{
		LEFT = -1,
		RIGHT = 1
	};

	public FACE_DIRECTION direction = FACE_DIRECTION.RIGHT;

	public static PlayerController player = null;

	public bool canJump = true;
	public bool canMove = true;
	public bool isOnGround = false;

	public float jumpPower = 400;
	public float jumpTimeout = 1.0f;
	public float maxSpeed = 40.0f;

	public string horizontalAxis = "Horizontal";
	public string verticalAxis = "Vertical";
	public string jumpButton = "Jump";

	private Rigidbody2D theRigidbody = null;
	private Transform theTransform = null;
	public BoxCollider2D feetCollider = null;
	public LayerMask groundLayer;

	void Awake(){
		theRigidbody = GetComponent<Rigidbody2D> ();
		theTransform = GetComponent<Transform> ();

		player = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
