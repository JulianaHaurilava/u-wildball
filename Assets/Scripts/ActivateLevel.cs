using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateLevel : MonoBehaviour
{
    [SerializeField] int levelNumber;

    public void StartLevel()
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
