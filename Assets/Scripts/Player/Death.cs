using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Death : MonoBehaviour
{
    private ParticleSystem _particles;
    private Rigidbody _rb;

    [SerializeField]
    private GameObject ball;
    void Start()
    {
        _particles = GetComponentInChildren<ParticleSystem>();
        _rb = GetComponent<Rigidbody>();
    }

    public void ActivateDestroy()
    {
        _rb.useGravity = false;
        ball.SetActive(false);
        _particles.Play();
    }
}
