using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool spawnAntType;
    public int workers;
    public int maxWorkers;
    public int soldiers;
    public int maxSoldiers;
    public int food;
    public int maxFood;
    public int water;
    public int maxWater;
    public int consumption;
    public int spawning;
    public float cycleTime;
    public int workersToMove;
    public int soldiersToMove;

    public GameObject playerHive;
    public PlayerHive playerbuildings;
    public EnemySpawning spawner;

    int foodWorkers;
    int foodWorkers1;
    int foodWorkers2;
    int foodWorkers3;
    int foodWorkers4;
    int foodWorkers5;

    int waterWorkers;
    int waterWorkers1;
    int waterWorkers2;
    int waterWorkers3;
    int waterWorkers4;
    int waterWorkers5;

    int hiveWorkers;
    int hiveSoldiers;

    int defenseWorkers;
    int defenseWorkers1;
    int defenseWorkers2;
    int defenseWorkers3;
    int defenseWorkers4;
    int defenseWorkers5;

    int foodSoldiers;
    int foodSoldiers1;
    int foodSoldiers2;
    int foodSoldiers3;
    int foodSoldiers4;
    int foodSoldiers5;

    int waterSoldiers;
    int waterSoldiers1;
    int waterSoldiers2;
    int waterSoldiers3;
    int waterSoldiers4;
    int waterSoldiers5;

    int defenseSoldiers;
    int defenseSoldiers1;
    int defenseSoldiers2;
    int defenseSoldiers3;
    int defenseSoldiers4;
    int defenseSoldiers5;


    public FoodNode[] foodNodes;
    public WaterNode[] waterNodes;
    public DefenceNode[] defenceNodes;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Cycle());
        playerHive = GameObject.Find("PlayerHive");
        playerbuildings = playerHive.GetComponent<PlayerHive>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerbuildings.workers >= maxWorkers)
        {
            playerbuildings.workers = maxWorkers;
        }
        if (playerbuildings.soldiers >= maxSoldiers)
        {
            playerbuildings.soldiers = maxSoldiers;
        }
        
        consumption = workers + soldiers;

        if (workers == 0 && soldiers == 0)
        {

        }

        switch (playerbuildings.farms)
        {
            case 5:
                consumption -= 100;
                break;
            case 4:
                consumption -= 80;
                break;
            case 3:
                consumption -= 60;
                break;
            case 2:
                consumption -= 40;
                break;
            case 1:
                consumption -= 20;
                break;
            default:
                consumption -= 0;
                break;
        }

        if(consumption < 0)
        {
            consumption = 0;
        }

        switch (playerbuildings.residential)
        {
            case 5:
                maxWorkers = 100;
                break;
            case 4:
                maxWorkers = 90;
                break;
            case 3:
                maxWorkers = 80;
                break;
            case 2:
                maxWorkers = 70;
                break;
            case 1:
                maxWorkers = 60;
                break;
            default:
                maxWorkers = 50;
                break;
        }

        switch (playerbuildings.barracks)
        {
            case 5:
                maxSoldiers = 100;
                break;
            case 4:
                maxSoldiers = 90;
                break;
            case 3:
                maxSoldiers = 80;
                break;
            case 2:
                maxSoldiers = 70;
                break;
            case 1:
                maxSoldiers = 60;
                break;
            default:
                maxSoldiers = 50;
                break;
        }

        switch (playerbuildings.nursery)
        {
            case 5:
                spawning = 6;
                break;
            case 4:
                spawning = 5;
                break;
            case 3:
                spawning = 4;
                break;
            case 2:
                spawning = 3;
                break;
            case 1:
                spawning = 2;
                break;
            default:
                spawning = 1;
                break;
        }

        switch (playerbuildings.foodStore)
        {
            case 5:
                maxFood = 200;
                break;
            case 4:
                maxFood = 180;
                break;
            case 3:
                maxFood = 160;
                break;
            case 2:
                maxFood = 140;
                break;
            case 1:
                maxFood = 120;
                break;
            default:
                maxFood = 100;
                break;
        }

        switch (playerbuildings.waterStore)
        {
            case 5:
                maxWater = 200;
                break;
            case 4:
                maxWater = 180;
                break;
            case 3:
                maxWater = 160;
                break;
            case 2:
                maxWater = 140;
                break;
            case 1:
                maxWater = 120;
                break;
            default:
                maxWater = 100;
                break;
        }
        

        hiveWorkers = playerbuildings.workers;
        hiveSoldiers = playerbuildings.soldiers;

        foodWorkers = foodWorkers1 + foodWorkers2 + foodWorkers3 + foodWorkers4 + foodWorkers5;
        waterWorkers = waterWorkers1 + waterWorkers2 + waterWorkers3 + waterWorkers4 + waterWorkers5;
        defenseWorkers = defenseWorkers1 + defenseWorkers2 + defenseWorkers3 + defenseWorkers4 + defenseWorkers5;
        foodSoldiers = foodSoldiers1 + foodSoldiers2 + foodSoldiers3 + foodSoldiers4 + foodSoldiers5;
        waterSoldiers = waterSoldiers1 + waterSoldiers2 + waterSoldiers3 + waterSoldiers4 + waterSoldiers5;
        defenseSoldiers = defenseSoldiers1 + defenseSoldiers2 + defenseSoldiers3 + defenseSoldiers4 + defenseSoldiers5;

        workers = foodWorkers + waterWorkers + defenseWorkers + hiveWorkers;
        soldiers = foodSoldiers + waterSoldiers + defenseSoldiers + hiveSoldiers;
    }

    public void ChangeAntSpawn()
    {
        spawnAntType = !spawnAntType;
    }


    IEnumerator Cycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(cycleTime);
            Debug.Log("Cycle Start");
            
            food -= consumption;
            water -= consumption;

            if (food <= 0)
            {
                playerbuildings.workers -= food / 2;
                playerbuildings.soldiers -= food / 2;
                food = 0;
            }

            if (water <= 0)
            {
                playerbuildings.workers -= water / 2;
                playerbuildings.soldiers -= water / 2;
                water = 0;
            }

            spawner.SpawnEnemyAnts();

            if (spawnAntType == false)
            {
                playerbuildings.workers += spawning;
            }

            else if (spawnAntType == true)
            {
                playerbuildings.soldiers += spawning;
            }

            for (int i = 0; i< foodNodes.Length; i++)
            {
                foodNodes[i].ProduceFood();
            }

            for (int i = 0; i < waterNodes.Length; i++)
            {
                waterNodes[i].ProduceWater();
            }

            for (int i = 0; i < foodNodes.Length; i++)
            {
                foodWorkers1 = foodNodes[0].workerAnts;
                foodSoldiers1 = foodNodes[0].soldierAnts;
                foodWorkers2 = foodNodes[1].workerAnts;
                foodSoldiers2 = foodNodes[1].soldierAnts;
                foodWorkers3 = foodNodes[2].workerAnts;
                foodSoldiers3 = foodNodes[2].soldierAnts;
                foodWorkers4 = foodNodes[3].workerAnts;
                foodSoldiers4 = foodNodes[3].soldierAnts;
                foodWorkers5 = foodNodes[4].workerAnts;
                foodSoldiers5 = foodNodes[4].soldierAnts;
            }

            for (int i = 0; i < waterNodes.Length; i++)
            {
                waterWorkers1 = waterNodes[0].workerAnts;
                waterSoldiers1 = waterNodes[0].soldierAnts;
                waterWorkers2 = waterNodes[1].workerAnts;
                waterSoldiers2 = waterNodes[1].soldierAnts;
                waterWorkers3 = waterNodes[2].workerAnts;
                waterSoldiers3 = waterNodes[2].soldierAnts;
                waterWorkers4 = waterNodes[3].workerAnts;
                waterSoldiers4 = waterNodes[3].soldierAnts;
                waterWorkers5 = waterNodes[4].workerAnts;
                waterSoldiers5 = waterNodes[4].soldierAnts;
            }

            for (int i = 0; i < defenceNodes.Length; i++)
            {
                defenseWorkers1 = defenceNodes[0].workerAnts;
                defenseSoldiers1 = defenceNodes[0].soldierAnts;
                defenseWorkers2 = defenceNodes[1].workerAnts;
                defenseSoldiers2 = defenceNodes[1].soldierAnts;
                defenseWorkers3 = defenceNodes[2].workerAnts;
                defenseSoldiers3 = defenceNodes[2].soldierAnts;
                defenseWorkers4 = defenceNodes[3].workerAnts;
                defenseSoldiers4 = defenceNodes[3].soldierAnts;
                defenseWorkers5 = defenceNodes[4].workerAnts;
                defenseSoldiers5 = defenceNodes[4].soldierAnts;
            }
        }
    }
}
