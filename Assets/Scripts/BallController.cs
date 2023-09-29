using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class BallControl : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float JumpHeight;
    [SerializeField] float GroundDistance;
    [SerializeField] LayerMask Ground;

    private Rigidbody ball;
    private Vector3 inputs;
    private bool isGrounded;
    private Transform groundChecker;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        inputs = Vector3.zero;
        isGrounded = true;
        groundChecker = transform;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);

        inputs = Vector3.zero;
        inputs.x = UnityEngine.Input.GetAxis("Horizontal");
        inputs.z = UnityEngine.Input.GetAxis("Vertical");
        if (inputs != Vector3.zero)
        {
            transform.forward = inputs;
        }

        if (UnityEngine.Input.GetButtonDown("Jump") && isGrounded)
        {
            ball.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }
    }

    void FixedUpdate()
    {
        ball.MovePosition(ball.position + inputs * Speed * Time.fixedDeltaTime);
    }
}
