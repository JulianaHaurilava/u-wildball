using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.TryGetComponent(out Rigidbody rb))
            {
                Thread.Sleep(3000);
                player.SetParent(transform);
                anim.SetTrigger("Seats");
            }
        }
    }

    public void FreePlayer()
    {
        player.SetParent(null);
    }
}
