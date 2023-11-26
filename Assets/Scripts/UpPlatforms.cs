using System;
using UnityEngine;

public class UpPlatforms : MonoBehaviour
{
    [SerializeField]
    private Animator[] platformAnimators = new Animator[3];
    [SerializeField]
    private int upCooldown;

    private bool activated = false;
    private int nextPlatform = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !activated)
        {
            activated = true;
            for (int i = 0; i < platformAnimators.Length; i++)
            {
                Invoke(nameof(UpPlatform), upCooldown);
            }
        }
    }
    private void UpPlatform()
    {
        platformAnimators[nextPlatform++].SetTrigger("UpPlatform");
    }
}
