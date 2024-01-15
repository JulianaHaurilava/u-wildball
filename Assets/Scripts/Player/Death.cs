using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
public class Death : MonoBehaviour
{
    private ParticleSystem _particles;
    private PlayerInput _playerInput;
    private PlayerMovement _playerMovement;

    [SerializeField]
    private GameObject ball;
    void Start()
    {
        _particles = GetComponentInChildren<ParticleSystem>();
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    public void ActivateDestroy()
    {
        _playerInput.HasInput = false;
        _playerMovement.StopPlayer();

        ball.SetActive(false);
        _particles.Play();
    }
}
