using UnityEngine;
using UnityEngine.InputSystem;

public class DisparoBolaFogo : MonoBehaviour
{
    public GameObject bolaFogo;

   public void LancarBolaFogo(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            GameObject bola = Instantiate(bolaFogo, transform.position, transform.rotation);

            bola.GetComponent<Rigidbody>().linearVelocity = transform.right * 10;
        }
    }
}
