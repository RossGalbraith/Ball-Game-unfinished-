using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class trackBall : MonoBehaviour
{
    private GameObject  player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Ball"); //Finds the ball among the objects
        if (!player)
        {
            Debug.Log("Make sure your player is tagged!!"); //Ensures the ball exists
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position; //Get to the ball while doging obsticles
    }
}
