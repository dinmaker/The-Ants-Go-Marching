using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBuildings : MonoBehaviour
{
    public GameObject controllerObject;
    public GameController controller;

    public int farms;
    public int nursery;
    public int barracks;
    public int residential;
    public int foodStore;
    public int waterStore;

    // Start is called before the first frame update
    void Start()
    {
        controllerObject = GameObject.Find("GameController");
        controller = controllerObject.GetComponent<GameController>();
    }

    void Update()
    {
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
        farms += 1;
    }

    public void AddNursery()
    {
        nursery += 1;
    }

    public void AddResidential()
    {
        residential += 1;
    }

    public void AddBarracks()
    {
        barracks += 1;
    }

    public void AddFoodStore()
    {
        foodStore += 1;
    }

    public void AddWaterStore()
    {
        waterStore += 1;
    }
}
