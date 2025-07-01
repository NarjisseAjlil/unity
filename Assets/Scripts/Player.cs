using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Keyboard.current.upArrowKey.isPressed)
            move.y += 1;
        if (Keyboard.current.downArrowKey.isPressed)
            move.y -= 1;
        if (Keyboard.current.leftArrowKey.isPressed)
            move.x -= 1;
        if (Keyboard.current.rightArrowKey.isPressed)
            move.x += 1;

        transform.position += (Vector3)move.normalized * moveSpeed * Time.deltaTime;
    }
}
