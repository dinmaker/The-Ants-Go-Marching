using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterNode : MonoBehaviour
{
    public GameObject controllerObject;
    public GameController controller;

    public int workerAnts;
    public int soldierAnts;

    public int production;
    public int defence;

    void Start()
    {
        controllerObject = GameObject.Find("GameController");
        controller = controllerObject.GetComponent<GameController>();

    }

    void Update()
    {
        production = soldierAnts + (workerAnts * 4);
        defence = workerAnts + (soldierAnts * 4);
    }

    public void ProduceWater()
    {
        controller.water += production;
    }
}
