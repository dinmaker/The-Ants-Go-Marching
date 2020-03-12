using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHive : MonoBehaviour
{
    public GameObject controllerObject;
    public GameController controller;

    public int farms;
    public int nursery;
    public int barracks;
    public int residential;
    public int foodStore;
    public int waterStore;

    public int workers;
    public int soldiers;

    public int defense;

    public Path path;
    public bool AorB;

    // Start is called before the first frame update
    void Start()
    {
        controllerObject = GameObject.Find("GameController");
        controller = controllerObject.GetComponent<GameController>();
    }

    void Update()
    {
        defense = workers + (soldiers * 4);

        if (farms > 5)
        {
            farms = 5;
        }
        if (nursery > 5)
        {
            nursery = 5;
        }
        if (barracks > 5)
        {
            barracks = 5;
        }
        if (residential > 5)
        {
            residential = 5;
        }
        if (foodStore > 5)
        {
            foodStore = 5;
        }
        if (waterStore > 5)
        {
            waterStore = 5;
        }

        if (workers > 0)
        {
            if (AorB == true)
            {
                path.WorkerNodeA = true;
            }
            else
            {
                path.WorkerNodeB = true;
            }
        }

        if (soldiers > 0)
        {
            if (AorB == true)
            {
                path.SoldierNodeA = true;
            }
            else
            {
                path.SoldierNodeB = true;
            }
        }
    }

    public void AddFarm()
    {
        switch (farms)
        {
            case 4:
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    farms += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    farms += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    farms += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    farms += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
                    farms += 1;
                }
                break;
        }
    }

    public void AddNursery()
    {
        switch (nursery)
        {
            case 4:
                if (workers >= 100)
                {
                    workers -= 100;
                    nursery += 1;
                }
                break;
            case 3:
                if (workers >= 80)
                {
                    workers -= 80;
                    nursery += 1;
                }
                break;
            case 2:
                if (workers >= 60)
                {
                    workers -= 60;
                    nursery += 1;
                }
                break;
            case 1:
                if (workers >= 40)
                {
                    workers -= 40;
                    nursery += 1;
                }
                break;
            default:
                if (workers >=20)
                {
                    workers -= 20;
                    nursery += 1;
                }
                break;
        }
    }

    public void AddResidential()
    {
        switch (residential)
        {
            case 4:
                if (workers >= 100)
                {
                    workers -= 100;
                    residential += 1;
                }
                break;
            case 3:
                if (workers >= 80 )
                {
                    workers -= 80;
                    residential += 1;
                }
                break;
            case 2:
                if (workers >= 60)
                {
                    workers -= 60;
                    residential += 1;
                }
                break;
            case 1:
                if (workers >= 40)
                {
                    workers -= 40;
                    residential += 1;
                }
                break;
            default:
                if (workers >= 20)
                {
                    workers -= 20;
                    residential += 1;
                }
                break;
        }
    }

    public void AddBarracks()
    {
        switch (barracks)
        {
            case 4:
                if (workers >= 100)
                {
                    workers -= 100;
                    barracks += 1;
                }
                break;
            case 3:
                if (workers >= 80 )
                {
                    workers -= 80;
                    barracks += 1;
                }
                break;
            case 2:
                if (workers >= 60 )
                {
                    workers -= 60;
                    barracks += 1;
                }
                break;
            case 1:
                if (controller.food >= 40)
                {
                    workers -= 40;
                    barracks += 1;
                }
                break;
            default:
                if (controller.food >= 20 )
                {
                    workers -= 20;
                    barracks += 1;
                }
                break;
        }
    }

    public void AddFoodStore()
    {
        switch (foodStore)
        {
            case 4:
                if (workers >= 100)
                {
                    workers -= 100;
                    foodStore += 1;
                }
                break;
            case 3:
                if (workers >= 80)
                {
                    workers -= 80;
                    foodStore += 1;
                }
                break;
            case 2:
                if (workers >= 60 )
                {
                    workers -= 60;
                    foodStore += 1;
                }
                break;
            case 1:
                if (workers >= 40 )
                {
                    workers -= 40;
                    foodStore += 1;
                }
                break;
            default:
                if (workers >= 20 )
                {
                    workers -= 20;
                    foodStore += 1;
                }
                break;
        }
    }

    public void AddWaterStore()
    {
        switch (waterStore)
        {
            case 4:
                if (workers >= 100 )
                {
                    workers -= 100;
                    waterStore += 1;
                }
                break;
            case 3:
                if (workers >= 80)
                {
                    workers -= 80;
                    waterStore += 1;
                }
                break;
            case 2:
                if (workers >= 60)
                {
                    workers -= 60;
                    waterStore += 1;
                }
                break;
            case 1:
                if (workers >= 40)
                {
                    workers -= 40;
                    waterStore += 1;
                }
                break;
            default:
                if (workers >= 20)
                {
                    workers -= 20;
                    waterStore += 1;
                }
                break;
        }
    }

    public void SendWorkers()
    {
        controller.workersToMove = workers / 2;
        workers -= controller.workersToMove;
    }

    public void SendSoldiers()
    {
        controller.soldiersToMove = soldiers / 2;
        soldiers -= controller.soldiersToMove;
    }

    public void ReceiveAnts()
    {
        workers += controller.workersToMove;
        controller.workersToMove = 0;
        soldiers += controller.soldiersToMove;
        controller.soldiersToMove = 0;
    }
}
