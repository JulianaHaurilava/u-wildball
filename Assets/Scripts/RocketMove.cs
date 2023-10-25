using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    // Start is called before the first frame update
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
                anim.SetTrigger("Seats");
            }
        }
    }
}
