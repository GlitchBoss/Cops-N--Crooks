using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;

    SpawnManager SM;

    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        if (instance != this)
            Destroy(gameObject);
        StartUp();
    }

    void StartUp()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    void LateUpdate()
    {
        if (player.transform.position.z >= 1000)
        {
            GameObject[] objsInScene = FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach(GameObject go in objsInScene)
            {
                if(go.transform.parent == null && go.transform.position != Vector3.zero)
                {
                    go.transform.position -= new Vector3(0, 0, 1000);
                }
            }
        }
        if (player.transform.position.x >= 1000)
        {
            GameObject[] objsInScene = FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject go in objsInScene)
            {
                if (go.transform.parent == null && go.transform.position != Vector3.zero)
                {
                    go.transform.position -= new Vector3(1000, 0, 0);
                }
            }
        }
    }
}
