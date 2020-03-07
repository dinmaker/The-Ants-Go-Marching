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
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    nursery += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    nursery += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    nursery += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    nursery += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
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
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    residential += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    residential += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    residential += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    residential += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
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
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    barracks += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    barracks += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    barracks += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    barracks += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
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
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    foodStore += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    foodStore += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    foodStore += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    foodStore += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
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
                if (controller.food >= 100 && controller.water >= 50)
                {
                    controller.food -= 100;
                    controller.water -= 50;
                    waterStore += 1;
                }
                break;
            case 3:
                if (controller.food >= 80 && controller.water >= 40)
                {
                    controller.food -= 80;
                    controller.water -= 40;
                    waterStore += 1;
                }
                break;
            case 2:
                if (controller.food >= 60 && controller.water >= 30)
                {
                    controller.food -= 60;
                    controller.water -= 30;
                    waterStore += 1;
                }
                break;
            case 1:
                if (controller.food >= 40 && controller.water >= 20)
                {
                    controller.food -= 40;
                    controller.water -= 20;
                    waterStore += 1;
                }
                break;
            default:
                if (controller.food >= 20 && controller.water >= 10)
                {
                    controller.food -= 20;
                    controller.water -= 10;
                    waterStore += 1;
                }
                break;
        }
    }
}
