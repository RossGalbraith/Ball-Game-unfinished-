using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerCollision : MonoBehaviour
        
{
    [SerializeField] private float knockbackStrength;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>(); //Identifies the properties of the collision object

        if(rb != null)
        {
            Vector3 direction = collision.transform.position - transform.position;
            direction.y = 0; //remove if player wants to go up when knocked back

            rb.AddForce(direction.normalized * knockbackStrength, ForceMode.Impulse); //Creates a knockback force which can be set in unity
        }
    }
}