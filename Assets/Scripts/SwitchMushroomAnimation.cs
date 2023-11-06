using System.Collections.Generic;
using UnityEngine;

public class SwitchMushroomAnimation : MonoBehaviour
{
    [SerializeField] List<AnimationClip> animations;
    [SerializeField] Animator anim;

    private void StartRandomAnimation()
    {
        anim.Play(animations[Random.Range(0, animations.Count)].name);
    }
}
