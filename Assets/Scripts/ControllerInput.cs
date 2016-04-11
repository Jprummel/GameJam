using UnityEngine;
using System.Collections;

public class ControllerInput : MonoBehaviour {
                    private PlayerMovement  _movement;
    [SerializeField]private int             _playerNumber;

    void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }
	// Update is called once per frame
	void Update () {
        XboxInput();
	}

    void XboxInput()
    {
        float leftX = Input.GetAxis(InputAxes.leftX + _playerNumber);
        
        Vector3 inputVector = new Vector3(0, 0, leftX);
                
        if (leftX != 0)
        {
            _movement.Move(inputVector);
        }

        if (Input.GetButton(InputAxes.a + _playerNumber))
        {
            _movement.Jump();
        }

        if (Input.GetButton(InputAxes.x + _playerNumber))
        {
            //Grappling hook function here
        }
    }
}
