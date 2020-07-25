using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VirtualJoystick joystick;
    public float speed = 350.0f;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rigid.AddForce(joystick.InputDirection * speed*10 * Time.deltaTime);
    }
}
