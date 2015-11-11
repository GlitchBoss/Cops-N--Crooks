using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpHeight;

    Rigidbody m_Rigidbody;
    CharacterController controller;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //m_Rigidbody.velocity = new Vector3(0, m_Rigidbody.velocity.y, speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 90, Space.Self);
        }
        controller.Move(transform.forward * speed);
    }
}
