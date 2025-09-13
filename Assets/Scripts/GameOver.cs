using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverPanel;

    private void OnCollisionEnter(Collision collision)
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;     
    }

    public void JogarNovamente()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
