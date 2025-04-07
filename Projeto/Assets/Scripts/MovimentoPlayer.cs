using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoPlayer : MonoBehaviour
{
    Rigidbody2D rb2d;

    float movimentoHorizontal;

    [Header("Dinamica")]
    public float velocidadeJogador = 5f;
    
    [Header("Pulo")]
    public float potenciaPulo = 5f;
    public float potenciaPuloBaixo = 2.5f;

    // [Header("Inspeciona Chão")]



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb2d.linearVelocity = new Vector2(
                movimentoHorizontal * velocidadeJogador, 
                rb2d.linearVelocityY);
    }

    public void MovimentoAWSD(InputAction.CallbackContext ctx)
    {
        movimentoHorizontal = ctx.ReadValue<Vector2>().x;
    }

    public void Pulo(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            rb2d.linearVelocity = new Vector2(
                    rb2d.linearVelocityX, 
                    potenciaPulo);
        }
        else if (ctx.canceled)
        {
            rb2d.linearVelocity = new Vector2(
                    rb2d.linearVelocityX, 
                    potenciaPuloBaixo);
        }
    }
}
