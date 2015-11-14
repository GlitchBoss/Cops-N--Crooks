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

	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player" && turnState == TurnState.readyToTurn)
        {
            turnState = TurnState.isTurning;
            if (direction == Direction.right)
                col.transform.Rotate(Vector3.up, 90, Space.Self);
            else if (direction == Direction.left)
                col.transform.Rotate(Vector3.up, -90, Space.Self);
            turnState = TurnState.hasTurned;
        }
    }
}
