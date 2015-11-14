using UnityEngine;
using System.Collections;

public class ObsticleSpawn : MonoBehaviour {

    public Transform[] spawnPoints;
    public Transform[] buildings;
    public Transform obsticle;
    public Transform obsticleSpawnPoint;
    public Transform nextSpawnPoint;
    public bool setSpawnPoint;

    SpawnManager SM;

    void Start()
    {
        SM = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        if(setSpawnPoint)
            SM.SetNextSpawnPoint(nextSpawnPoint);
        Spawn();
    }

    void Spawn()
    {
        foreach(Transform t in spawnPoints)
        {
            int i = Random.Range(0, buildings.Length);
            Transform tr = Instantiate(buildings[i], t.position, buildings[i].rotation) as Transform;
            tr.SetParent(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            SM.OnPlayerPassedObsticle();
        }
    }
}
