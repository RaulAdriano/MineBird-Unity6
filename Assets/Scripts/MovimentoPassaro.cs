using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoPassaro : MonoBehaviour
{
    Rigidbody rb;
    public float forcaSalto = 5f;
    public float velocidadeFrente = 3f;
    public AudioSource saltarAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody> ();    
        
    }

    public void Saltar(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            saltarAudioSource.Play ();
            rb.linearVelocity = new Vector3 (rb.linearVelocity.x, forcaSalto, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(velocidadeFrente,rb.linearVelocity.y,0);
    }
}
