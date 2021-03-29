using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float playerDistance;
    public GameObject[] points;
    public PositionManager master;
    public float speed;
   
    void Start()
    {
        
    }

    void Update()
    {
        Controls();
        FindPosition();
    }

    public void FindPosition()
    {
       
       playerDistance = Vector3.Distance(points[master.currentPoint].transform.position, this.transform.position);
     
      
    }

    public void Controls()
    {
        speed = Random.Range(1, 3);
        this.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2, 0);
        }
        
    }
}
