using UnityEngine.InputSystem;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustForce = 10f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        thrust.Enable();
    }

    private void FixedUpdate()
    {
        if(thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.fixedDeltaTime);
        }
    }
}
