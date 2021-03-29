using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionManager : MonoBehaviour
{
    public float[] car_positons;
    public GameObject Player;
    public float PlayerPosition;
    public GameObject[] AI;
    public int currentPos;
    public int currentPoint;
    public Text posText;
    //   public Text posText;


    void Start()
    {
        
    }

   
    void Update()
    {
        PositionCal();
        posText.text = currentPos.ToString() + "/ " + car_positons.Length;
    }

    public void PositionCal()
    {
        car_positons[0] = Player.GetComponent<PlayerController>().playerDistance;
        Debug.Log(AI[0].GetComponent<AiController>().aiDistance);
     
        car_positons[1] = AI[0].GetComponent<AiController>().aiDistance;
        car_positons[2] = AI[1].GetComponent<AiController>().aiDistance;
        car_positons[3] = AI[2].GetComponent<AiController>().aiDistance;
    
      
        PlayerPosition = Player.GetComponent<PlayerController>().playerDistance;

        Array.Sort(car_positons);
        Array.Reverse(car_positons);

        int x = Array.IndexOf(car_positons, PlayerPosition);

        switch (x)
        {
            case 0:
                currentPos = 1;
                break;
            case 1:
                currentPos = 2;
                break;
            case 2:
                currentPos = 3;
                break;
            case 3:
                currentPos = 4;
                break;
        }

    }
}



