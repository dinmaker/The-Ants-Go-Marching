﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodNode : MonoBehaviour
{
    public GameObject controllerObject;
    public GameController controller;

    public int workerAnts;
    public int soldierAnts;
    int initialEnemyCount;
    public int enemyAnts;

    public int production;
    public int defence;

    public Button button;
    public Path[] paths;
    bool workersActive;
    bool soldiersActive;

    void Start()
    {
        controllerObject = GameObject.Find("GameController");
        controller = controllerObject.GetComponent<GameController>();

    }

    void Update()
    {
        production = soldierAnts + (workerAnts * 4);
        defence = workerAnts + (soldierAnts * 4);

        if (workerAnts > 0 || soldierAnts > 0)
        {
            button.gameObject.SetActive(true);
        }

        if (workerAnts > 0 && !workersActive)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                if (paths[i].WorkerNodeA == true)
                {
                    paths[i].WorkerNodeB = true;
                }
                else
                {
                    paths[i].WorkerNodeA = true;
                }
            }

            workersActive = true;
        }

        if (soldierAnts > 0 && !soldiersActive)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                if (paths[i].SoldierNodeA == true)
                {
                    paths[i].SoldierNodeB = true;
                }
                else
                {
                    paths[i].SoldierNodeA = true;
                }
            }

            soldiersActive = true;
        }

    }

    public void ProduceFood()
    {
        controller.food += production;
    }

    public void SendWorkers()
    {
        controller.workersToMove = workerAnts / 2;
        workerAnts -= controller.workersToMove;
    }

    public void SendSoldiers()
    {
        controller.soldiersToMove = soldierAnts / 2;
        soldierAnts -= controller.soldiersToMove;
    }

    public void ReceiveAnts()
    {
        initialEnemyCount = enemyAnts;
        if (enemyAnts > 0)
        {
            enemyAnts -= (controller.soldiersToMove * 4) + controller.workersToMove;
            if (enemyAnts <= 0)
            {
                workerAnts += controller.workersToMove -(initialEnemyCount/2);
                controller.workersToMove = 0;
                soldierAnts += controller.soldiersToMove - (initialEnemyCount/2);
                controller.soldiersToMove = 0;
                initialEnemyCount = 0;
                enemyAnts = 0;
            }
            else
            {
                workerAnts = 0;
                soldierAnts = 0;
                controller.workersToMove = 0;
                controller.soldiersToMove = 0;
            }
        }
        else
        {
            workerAnts += controller.workersToMove;
            controller.workersToMove = 0;
            soldierAnts += controller.soldiersToMove;
            controller.soldiersToMove = 0;
        }
    }
}
