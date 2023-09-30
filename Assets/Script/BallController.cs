using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        //Debug.Log(rb.velocity.magnitude);
    }
}
