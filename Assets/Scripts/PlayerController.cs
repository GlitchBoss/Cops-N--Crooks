using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Vector3 speed;
    public float jumpHeight;

    Rigidbody m_Rigidbody;
    //CharacterController controller;
    bool gameEnded;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
        gameEnded = false;
    }

    void Update()
    {
        if (gameEnded)
        {
            m_Rigidbody.velocity = Vector3.zero;
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
        }
        m_Rigidbody.velocity = new Vector3(0, m_Rigidbody.velocity.y, speed.z);
        //m_Rigidbody.velocity = speed;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Building")
            GameOver();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Building")
        {
            GameOver();
        }
    }

    void GameOver()
    {
        GameManager.instance.GameOver();
        gameEnded = true;
    }
}
