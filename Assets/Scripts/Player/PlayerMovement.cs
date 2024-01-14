using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed;

    [Header("Jump")]
    [SerializeField] float jumpForce;
    [SerializeField] float jumpCooldown;
    [SerializeField] float airMultiplier;

    [Header("Ground Check")]
    [SerializeField] LayerMask whatIsGround;
    private bool grounded;

    [SerializeField] Transform orientation;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void Update()
    {
        SpeedControl();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = false;
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    public void MovePlayer(Vector3 input)
    {
        Vector3 moveDirection = orientation.forward * input.z + orientation.right * input.x;

        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
        }
        else
        {
            rb.AddForce(moveDirection.normalized * speed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    public void Jump()
    {
        if (grounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
}
