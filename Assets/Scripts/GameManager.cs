using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    // public GameObject completeLevelUI;

    // public void CompleteLevel()
    // {
    //     completeLevelUI.SetActive(true);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    // }
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
