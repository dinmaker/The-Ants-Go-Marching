using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public int enemyAnts;
    public int spawnAmount;
    public int maxAnts;
    public DefenceNode spawnPointA;
    public DefenceNode spawnPointB;
    public DefenceNode spawnPointC;
    public FoodNode spawnPointD;
    public WaterNode spawnPointE;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnPointA.enemyAnts <= 0)
        {
            //YOU WIN
        }
    }

    public void SpawnEnemyAnts()
    {
        if (spawnPointA.enemyAnts < maxAnts)
        {
            spawnPointA.enemyAnts += spawnAmount;
        }
        else if (spawnPointB.enemyAnts < maxAnts)
        {
            spawnPointB.enemyAnts += spawnAmount;
        }
        else if (spawnPointC.enemyAnts < maxAnts)
        {
            spawnPointC.enemyAnts += spawnAmount;
        }
        else if (spawnPointD.enemyAnts < maxAnts)
        {
            spawnPointD.enemyAnts += spawnAmount;
        }
    }
}
