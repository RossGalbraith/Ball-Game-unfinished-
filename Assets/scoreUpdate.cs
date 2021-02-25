using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Goale;
    
    Text Current;
    private int playerc = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball"); //Finds the ball
        Goale = GameObject.FindGameObjectWithTag("Respawn"); //Finds the two goals
        Current = gameObject.GetComponent<Text>();
      Current.text = "Score:" + playerc; //Sets the intial score as 0
    }

    // Update is called once per frame
    void Update()
    {
        Current.text = "Score:" + playerc; //Update the score as the game happens
        if (playerc == 3) 
        {
            Current.text = "You win"; // Game over after scoring 3 times
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Respawn")
        {
            playerc = playerc + 1; //If the ball goes in the goal increase the score by 1
        }

        
    }
}
