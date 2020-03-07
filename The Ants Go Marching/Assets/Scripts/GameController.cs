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

    public FoodNode[] foodNodes;
    public WaterNode[] waterNodes;
    public DefenceNode[] defenceNodes;


    public GameObject playerHive;
    public PlayerHive playerbuildings;

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

    }


    IEnumerator Cycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(10.0f);
            Debug.Log("Cycle Start");
            
            food -= consumption;
            water -= consumption;

            if (spawnAntType == false)
            {
                playerbuildings.workers += spawning;
            }
            else if (spawnAntType == true)
            {
                playerbuildings.soldiers += spawning;
            }

            for (int i = 0; i < foodNodes.Length; i++)
            {
                workers += foodNodes[i].workerAnts;
                soldiers += foodNodes[i].soldierAnts;
            }

            for (int i = 0; i < waterNodes.Length; i++)
            {
                workers += waterNodes[i].workerAnts;
                soldiers += waterNodes[i].workerAnts;
            }

            for (int i = 0; i < defenceNodes.Length; i++)
            {
                workers += defenceNodes[i].workerAnts;
                soldiers += defenceNodes[i].soldierAnts;
            }

            workers += playerbuildings.workers;
            soldiers += playerbuildings.soldiers;

            for (int i = 0; i< foodNodes.Length; i++)
            {
                foodNodes[i].ProduceFood();
            }

            for (int i = 0; i < waterNodes.Length; i++)
            {
                waterNodes[i].ProduceWater();
            }
        }
    }
}
