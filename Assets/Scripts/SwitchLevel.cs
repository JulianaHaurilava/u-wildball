using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
    private Death deathController;
    private int levelsNumber = 4;

    private void Start()
    {
        deathController = GetComponent<Death>();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "DeathTag":
                deathController.ActivateDestroy();
                Invoke("ReloadCurrentScene", 1.5f);
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

    private void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
