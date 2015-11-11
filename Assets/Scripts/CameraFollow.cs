using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float zOffset;

    //void FixedUpdate()
    //{
    //    transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + zOffset);
    //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, target.position.z);
    //}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Obsticle")
            Destroy(other.gameObject);
    }
}
