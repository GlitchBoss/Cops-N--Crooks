using UnityEngine;
using System.Collections;

public class TurnSignalSender : MonoBehaviour {

    Turn turn;

    void Start()
    {
        turn = GetComponentInParent<Turn>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player" || turn.turnState != Turn.TurnState.waitingForTurnSignal)
            return;

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            SendTurnSignal();
        }
    }

    void SendTurnSignal()
    {
        if(turn.turnState == Turn.TurnState.waitingForTurnSignal)
        {
            turn.turnState = Turn.TurnState.readyToTurn;
        }
    }
}
