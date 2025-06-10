using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Core : MonoBehaviour
{
    Rigidbody2D rb2D;

    [Header("Ground Checking")]
    public LayerMask groundLayer;


    protected bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        return Physics2D.Raycast(position, direction, distance, groundLayer);
    }
}
