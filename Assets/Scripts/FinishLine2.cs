using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine2 : MonoBehaviour
{
    [SerializeField] float nextSceneDelay = 1f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("NextScene", nextSceneDelay);
        }
    }
    void NextScene()
    {
        SceneManager.LoadScene(3);
    }
}
