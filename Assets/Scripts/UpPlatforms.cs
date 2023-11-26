using System;
using UnityEngine;

public class UpPlatforms : MonoBehaviour
{
    [SerializeField]
    private Animator[] platformAnimators = new Animator[3];

    private bool activated = false;

    public void ActivatePlatforms()
    {
        activated = !activated;
        for (int i = 0; i < platformAnimators.Length; i++)
        {
            UpPlatform(i);
        }
    }

    private void UpPlatform(int platformNum)
    {
        platformAnimators[platformNum].SetBool("PlatformActivated", activated);
    }
}
