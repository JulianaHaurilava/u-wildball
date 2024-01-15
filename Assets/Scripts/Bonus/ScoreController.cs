using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreNumber;
    private int scores = 0;
    private void UpdateScore()
    {
        scoreNumber.text = (++scores).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bonus"))
        {
            UpdateScore();
        }
    }
}
