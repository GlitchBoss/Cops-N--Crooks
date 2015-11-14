using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public Transform[] obsticles;
    public Transform[] turns;
    public Transform nextSpawnPoint;
    public int maxObsticles;
    public int numOfObsticles;
    public IntRange nextTurnObsticle = new IntRange(4, 8);

    int spawnTurnObsticle;

    public void OnPlayerPassedObsticle()
    {
        numOfObsticles--;
        if (numOfObsticles >= maxObsticles)
            return;
        if(spawnTurnObsticle <= 0)
        {
            int index = Random.Range(0, turns.Length);
            Instantiate(turns[index], nextSpawnPoint.position, nextSpawnPoint.rotation);
            spawnTurnObsticle = nextTurnObsticle.Random;
        }
        else
        {
            int index = Random.Range(0, obsticles.Length);
            Instantiate(obsticles[index], nextSpawnPoint.position, nextSpawnPoint.rotation);
            spawnTurnObsticle--;
        }
        numOfObsticles++;
    }

    public void SetNextSpawnPoint(Transform spawnPoint)
    {
        nextSpawnPoint = spawnPoint;
    }
}
