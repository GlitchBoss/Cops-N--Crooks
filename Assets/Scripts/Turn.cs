using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            col.transform.Rotate(Vector3.up, 90, Space.Self);
        }
    }
}
