using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItext : MonoBehaviour
{
    public GameObject TextBox;

    string soldiersUI;
    string maxSoldiersUI;
    string workersUI;
    string maxWorkersUI;
    string foodUI;
    string maxFoodUI;
    string waterUI;
    string maxWaterUI;
    string consumptionUI;
    string spawningUI;

    public GameController gcValues;

    // Update is called once per frame
    void Update()
    {
        if (TextBox.tag == "soldierText")
        {
            soldiersUI = gcValues.soldiers.ToString();
            maxSoldiersUI = gcValues.maxSoldiers.ToString();
            TextBox.GetComponent<Text>().text = soldiersUI + " / " + maxSoldiersUI;
        }

        else if (TextBox.tag == "workerText")
        {
            workersUI = gcValues.workers.ToString();
            maxWorkersUI = gcValues.maxWorkers.ToString();
            TextBox.GetComponent<Text>().text = workersUI + " / " + maxWorkersUI;
        }

        else if (TextBox.tag == "foodText")
        {
            foodUI = gcValues.food.ToString();
            maxFoodUI = gcValues.maxFood.ToString();
            TextBox.GetComponent<Text>().text = foodUI + " / " + maxFoodUI;
        }

        else if (TextBox.tag == "waterText")
        {
            waterUI = gcValues.water.ToString();
            maxWaterUI = gcValues.maxWater.ToString();
            TextBox.GetComponent<Text>().text = waterUI + " / " + maxWaterUI;
        }

        else if (TextBox.tag == "consumptionText")
        {
            consumptionUI = gcValues.consumption.ToString();
            TextBox.GetComponent<Text>().text = consumptionUI;
        }

        else if (TextBox.tag == "spawnText")
        {
            spawningUI = gcValues.spawning.ToString();
            TextBox.GetComponent<Text>().text = spawningUI;
        }

    }


}
