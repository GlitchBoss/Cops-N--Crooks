using UnityEngine;
using System.Collections;

public class TurnSignalSender : MonoBehaviour {

    public Turn turn;

    void Start()
    {
        turn = GetComponentInParent<Turn>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            Debug.LogWarning("Not Player!");
            return;
        }
        Debug.Log("Waiting For Turn Signal...");
        //if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
            SendTurnSignal();
            Debug.Log("Sending Turn Signal...");
        //}
    }

    void SendTurnSignal()
    {
        if(turn.turnState == Turn.TurnState.waitingForTurnSignal)
        {
            turn.turnState = Turn.TurnState.readyToTurn;
            Debug.Log("Sent Turn Signal.");
            return;
        }
        Debug.LogWarning("Didn't Send Turn Signal!");
    }
}
