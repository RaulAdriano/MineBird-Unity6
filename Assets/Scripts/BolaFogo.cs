using UnityEngine;

public class BolaFogo : MonoBehaviour
{
    public GameObject explosaoTerra;
    public GameObject explosaoGenerica;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terra"))
        {
            Instantiate(explosaoTerra,collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
        else
        {
            Instantiate(explosaoGenerica, transform.position, transform.rotation);
        }
            Destroy(gameObject);
    }
}
