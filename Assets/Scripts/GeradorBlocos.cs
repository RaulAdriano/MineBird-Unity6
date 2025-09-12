using UnityEngine;

public class GeradorBlocos : MonoBehaviour
{
    public GameObject[] blocosDisponiveis;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int indice = Random.Range(0, blocosDisponiveis.Length);

            Instantiate(blocosDisponiveis[indice], new Vector3(transform.position.x + 98,0,0), transform.rotation);

            transform.position += new Vector3(98, 0, 0);
        }
    }
}
