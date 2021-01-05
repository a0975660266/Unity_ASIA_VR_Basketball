using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("投籃機");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
