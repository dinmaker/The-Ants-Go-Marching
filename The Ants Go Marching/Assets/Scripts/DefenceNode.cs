using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceNode : MonoBehaviour
{
    public GameObject controllerObject;
    public GameController controller;

    public int workerAnts;
    public int soldierAnts;
    
    public int defence;

    void Start()
    {
        controllerObject = GameObject.Find("GameController");
        controller = controllerObject.GetComponent<GameController>();

    }

    void Update()
    {
        defence = workerAnts + (soldierAnts * 4);
    }
    
}
