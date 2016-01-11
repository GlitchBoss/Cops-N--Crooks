using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

    public enum TurnState
    {
        waitingForTurnSignal,
        readyToTurn,
        isTurning,
        hasTurned
    }

    public enum Direction
    {
        left,
        right
    }

    public TurnState turnState = TurnState.waitingForTurnSignal;

    public Direction direction = Direction.right;

	void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && turnState == TurnState.readyToTurn)
        {
            turnState = TurnState.isTurning;
            Debug.Log("Turning...");
            if (direction == Direction.right)
                other.transform.Rotate(Vector3.up, 90, Space.Self);
            else if (direction == Direction.left)
                other.transform.Rotate(Vector3.up, -90, Space.Self);
            turnState = TurnState.hasTurned;
            Debug.Log("Turned.");
        }
    }
}
