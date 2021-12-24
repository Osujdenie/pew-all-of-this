using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;

    public PressButtons leftButton;
    public PressButtons rightButton;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || leftButton.isPressed)
            transform.position += Vector3.left * speed;

        if (Input.GetKey(KeyCode.RightArrow) || rightButton.isPressed)
            transform.position += Vector3.right * speed;
    }
}
