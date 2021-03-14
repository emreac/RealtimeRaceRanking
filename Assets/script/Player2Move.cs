using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float distanceTravelled = 0;
    Vector3 lastPosition;

    private float randomSpeed;
    private float randomRightSpeed;
    private float randomLeftSpeed;


    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RandomMove();
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
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

    public void DistanceCalculate()
    {


    }
}
