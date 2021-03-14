using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDistances : MonoBehaviour
{
    Player1Move player1Move;
    Player2Move player2Move;

    void Start()
    {
        player1Move = GetComponent<Player1Move>();
        player2Move = GetComponent<Player2Move>();

    }

    // Update is called once per frame
    void Update()

    {
        Player1Dis();
        Player2Dis();

    }

    void Player1Dis()
    {
        Debug.Log(player1Move.distanceTravelled);
    }
    void Player2Dis() {

        Debug.Log(player2Move.distanceTravelled);

    }
}
