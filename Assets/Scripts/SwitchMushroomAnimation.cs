using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMushroomAnimation : MonoBehaviour
{
    [SerializeField] List<Animation> animations;
    [SerializeField] Animator animator;
    void Start()
    {
        animator.
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.tri)
        {

        }
    }

    public void SetTrigger()
    {
        animator.SetTrigger("AnimEnded");
    }

    public void SwitchAnimation()
    {
        animator.anima
    }
}
