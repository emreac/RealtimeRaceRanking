using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    private PlayerDistances playerDistances;


    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;



    float distanceTravelled = 0;
    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

   
    void Update()
    {
     
   
    }

    public void ShowDistance()
    {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        Debug.Log(distanceTravelled);


    }

    public void ListOfDistances()
    {



    }

}
