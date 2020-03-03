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

    // Update is called once per frame
    void Update()
    {

    }
}
