using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]private float _maxSpeed;
	[SerializeField]private float _speed;
	                private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement ();
	}

	void Movement()
	{
        
		float z = Input.GetAxis("Horizontal");
        if (rb.velocity.magnitude > _maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * _maxSpeed;
        }
		Vector3 position = new Vector3(0, 0, z);
		rb.AddForce(position * _speed);
	}
}
