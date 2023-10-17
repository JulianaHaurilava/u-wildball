using UnityEngine;

public class SuperJump : MonoBehaviour
{
    [SerializeField] float superJumpForce;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.TryGetComponent(out Rigidbody rb))
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
                rb.AddForce(transform.up * superJumpForce, ForceMode.Impulse);
            }
        }
    }
}
