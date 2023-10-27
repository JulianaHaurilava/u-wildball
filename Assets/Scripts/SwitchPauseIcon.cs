using UnityEngine;

public class SwitchPauseIcon : MonoBehaviour
{
    private bool isPaused;
    [SerializeField] Sprite pauseSprite;
    [SerializeField] Sprite resumeSprite;

    private SpriteRenderer spriteR;

    private void Start()
    {
        isPaused = false;

        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    public void SwitchPauseSprite()
    {
        if (isPaused)
        {
            spriteR.sprite = pauseSprite;
        }
        else
        {
            spriteR.sprite = resumeSprite;
        }
        isPaused = !isPaused;
    }
}
