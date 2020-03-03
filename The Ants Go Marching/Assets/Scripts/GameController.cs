using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool spawnAntType;
    int workerAnts;
    int maxWorkers;
    int soldierAnts;
    int maxSoldiers;


    int food;
    int maxFood;
    int water;
    int maxWater;

    int consumption;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (workerAnts >= maxWorkers)
        {
            workerAnts = maxWorkers;
        }
        if (soldierAnts >= maxSoldiers)
        {
            soldierAnts = maxSoldiers;
        }
    }
}
