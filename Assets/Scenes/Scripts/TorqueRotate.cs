using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Fixedupdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            
        }
    }
}
