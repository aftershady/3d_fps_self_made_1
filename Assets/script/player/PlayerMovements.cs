using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;
    
       if (Keyboard.current.FindKeyOnCurrentKeyboardLayout("z").isPressed)
    direction.z += 1;

        if (Keyboard.current.FindKeyOnCurrentKeyboardLayout("s").isPressed)
    direction.z -= 1;

        if (Keyboard.current.FindKeyOnCurrentKeyboardLayout("q").isPressed)
    direction.x -= 1;

        if (Keyboard.current.FindKeyOnCurrentKeyboardLayout("d").isPressed)
    direction.x += 1;
    
        rb.MovePosition(rb.position +
            direction.normalized * speed * Time.fixedDeltaTime);
    }
}