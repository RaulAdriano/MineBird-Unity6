using TMPro;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    private int pontos = 0;

    public TMP_Text pontosText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            pontos++;
            pontosText.text = pontos.ToString();

            Destroy(other.gameObject);            
        }
    }
}
