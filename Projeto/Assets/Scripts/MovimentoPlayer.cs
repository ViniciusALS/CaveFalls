using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class MovimentoPlayer : MonoBehaviour
{
    Rigidbody2D rb2d;

    float movimentoHorizontal;

    [Header("Movimentos")]
    public float velocidadeJogador = 5f;
    public float potenciaPulo = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.linearVelocity = 
                new Vector2(
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
            rb2d.linearVelocity = 
                    new Vector2(
                        rb2d.linearVelocityX, 
                        potenciaPulo);
        }
    }
}
