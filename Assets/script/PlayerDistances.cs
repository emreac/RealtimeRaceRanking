using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDistances : MonoBehaviour
{
    Move move;
   // public Text distanceText;
    //Players
    public GameObject player;




    void Start()
    {

        move = GetComponent<Move>();
        Debug.Log(move.distanceTravelled);

    }
    private void Awake()
    {
        
    }

    void Update()
    {
       
    }

    void PlayerMove()
    {
        
    }

  

    private void FixedUpdate()
    {
 
        

        
    }

}
