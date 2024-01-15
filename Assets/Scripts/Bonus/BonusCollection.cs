using UnityEngine;

[RequireComponent (typeof(Collider))]
public class BonusCollection : MonoBehaviour
{
    private ParticleSystem _particles;
    private Animator _animator;
    private Collider _collider;


    private void Start()
    {
        _collider = GetComponent<Collider>();
        _particles = GetComponentInChildren<ParticleSystem>();
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _collider.enabled = false;
            _particles.Play();
            _animator.SetTrigger("Collected");
        }
    }

    private void Destroy()
    {
        Destroy(transform.parent.gameObject);
    }
}
