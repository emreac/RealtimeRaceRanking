using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public float distanceTravelled = 0;
    Vector3 lastPosition;

    public int distanceNumber;


    private float randomSpeed;
    private float randomRightSpeed;
    private float randomLeftSpeed;




    void Start()
    {
        lastPosition = transform.position;
   
    }
    void Update()
    {
       
    }

    public void DistanceCalculate()
    {

        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        Debug.Log(distanceTravelled);
        lastPosition = transform.position;
    }

    public void RandomMove()
    {
        randomSpeed = Random.Range(1, 15);
        randomRightSpeed = Random.Range(2, 5);
        randomLeftSpeed = Random.Range(3, 6);

        transform.Translate(Vector3.forward * Time.deltaTime * randomSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * randomRightSpeed);
        transform.Translate(Vector3.left * Time.deltaTime * randomLeftSpeed);
    }



}
