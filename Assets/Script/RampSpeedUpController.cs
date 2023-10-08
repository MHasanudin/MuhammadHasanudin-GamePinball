using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSpeedUpController : MonoBehaviour
{
    public float multiplier;

    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Rigidbody RBBola = bola.GetComponent<Rigidbody>();
            RBBola.velocity *= multiplier;

            Debug.Log("SpeedUp");
        }
    } 
}
