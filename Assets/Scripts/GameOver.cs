using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverPanel;
    public AudioSource gameOverAudioSource;

    private void OnCollisionEnter(Collision collision)
    {
        gameOverAudioSource.Play();
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;     
    }

    public void JogarNovamente()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
