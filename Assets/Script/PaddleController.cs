using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [Header("Tombol untuk paddle")]
    public KeyCode Paddle;

    private float targetPressed;
    private float targetReleased;

    private HingeJoint HJoint;

    private void Start()
    {
        HJoint = GetComponent<HingeJoint>();

        targetPressed = HJoint.limits.max;
        targetReleased = HJoint.limits.min;
    }

    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring JSpring = GetComponent<HingeJoint>().spring;

        if (Input.GetKey(Paddle))
        {
            JSpring.targetPosition = targetPressed;
        }
        else
        {
            JSpring.targetPosition = targetReleased;
        }

        HJoint.spring = JSpring;
    }
}
