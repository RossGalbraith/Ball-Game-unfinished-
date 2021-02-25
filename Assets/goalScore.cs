using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScore : MonoBehaviour
{
    Vector3 originalPos;
    public Transform Ball;

    void Start()
    {
        originalPos = new Vector3(Ball.transform.position.x, Ball.transform.position.y, Ball.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position;

    }
   void OnCollisionEnter(Collision Ball)
    {
        if (Ball.gameObject.tag == "Respawn")
        {
            gameObject.transform.position = originalPos;
        }

    }
}
