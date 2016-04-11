using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]private float       _maxSpeed;
	[SerializeField]private float       _speed;
    [SerializeField]private float       _jumpHeight;
                    private bool        _isGrounded;
	                private Rigidbody   _rb;
	// Use this for initialization
	void Start () 
    {
		_rb = GetComponent<Rigidbody>();
	}

	public void Move(Vector3 vectorValue)
	{
        if (_rb.velocity.magnitude > _maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * _maxSpeed;
            _speed = _maxSpeed;
        }

        _rb.velocity = vectorValue * _speed;
	}

    public void Jump()
    {
        if (_isGrounded == true)
        {
            _rb.AddForce(0, _jumpHeight, 0);
            _isGrounded = false;
        }
    }

    void OnCollisionEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            _isGrounded = true;
        }
    }
}
