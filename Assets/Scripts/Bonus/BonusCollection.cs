using UnityEngine;

public class BonusCollection : MonoBehaviour
{
    private ParticleSystem _particles;
    private Animator _animator;

    private void Start()
    {
        _particles = GetComponentInChildren<ParticleSystem>();
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _particles.Play();
            _animator.SetTrigger("Collected");
        }
    }

    private void Destroy()
    {
        Destroy(transform.parent.gameObject);
    }
}
