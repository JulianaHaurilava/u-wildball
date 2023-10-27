using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{

    private int levelsNumber = 3;
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "DeathTag":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;

            case "FinishTag":
                if (SceneManager.GetActiveScene().buildIndex < levelsNumber)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    SceneManager.LoadScene(0);
                }

                break;

            default:
                break;
        }
    }
}
