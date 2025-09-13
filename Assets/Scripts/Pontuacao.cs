using TMPro;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    private int pontos = 0;

    public TMP_Text pontosText;
    public AudioSource pontuacaoAudioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            pontos++;
            pontosText.text = pontos.ToString();
            pontuacaoAudioSource.Play();

            Destroy(other.gameObject);

            Time.timeScale += 0.01f;
        }
    }
}
