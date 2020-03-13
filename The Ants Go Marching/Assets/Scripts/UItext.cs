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

    string foodWorkersUI;
    string foodWorkers1UI;
    string foodWorkers2UI;
    string foodWorkers3UI;
    string foodWorkers4UI;

    string waterWorkersUI;
    string waterWorkers1UI;
    string waterWorkers2UI;
    string waterWorkers3UI;
    string waterWorkers4UI;

    string defenseWorkersUI;
    string defenseWorkers1UI;
    string defenseWorkers2UI;
    string defenseWorkers3UI;
    string defenseWorkers4UI;

    string foodSoldiersUI;
    string foodSoldiers1UI;
    string foodSoldiers2UI;
    string foodSoldiers3UI;
    string foodSoldiers4UI;

    string waterSoldiersUI;
    string waterSoldiers1UI;
    string waterSoldiers2UI;
    string waterSoldiers3UI;
    string waterSoldiers4UI;

    string defenseSoldiersUI;
    string defenseSoldiers1UI;
    string defenseSoldiers2UI;
    string defenseSoldiers3UI;
    string defenseSoldiers4UI;

    public GameController gcValues;

    // Update is called once per frame
    void Update()
    {
        if (TextBox.tag == "soldierText")
        {
            soldiersUI = gcValues.soldiers.ToString();
            maxSoldiersUI = gcValues.maxSoldiers.ToString();
            TextBox.GetComponent<Text>().text = soldiersUI; //+ " / " + maxSoldiersUI;
        }

        else if (TextBox.tag == "workerText")
        {
            workersUI = gcValues.workers.ToString();
            maxWorkersUI = gcValues.maxWorkers.ToString();
            TextBox.GetComponent<Text>().text = workersUI; //+ " / " + maxWorkersUI;
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

        else if (TextBox.tag == "foodNodeTxt0")
        {
            foodSoldiersUI = gcValues.foodSoldiers1.ToString();
            foodWorkersUI = gcValues.foodWorkers1.ToString();
            TextBox.GetComponent<Text>().text = "W " + foodWorkersUI + " S " + foodSoldiersUI;
        }

        else if (TextBox.tag == "foodNodeTxt1")
        {
            foodSoldiers1UI = gcValues.foodSoldiers2.ToString();
            foodWorkers1UI = gcValues.foodWorkers2.ToString();
            TextBox.GetComponent<Text>().text = "W " + foodWorkers1UI + " S " + foodSoldiers1UI;
        }

        else if (TextBox.tag == "foodNodeTxt2")
        {
            foodSoldiers2UI = gcValues.foodSoldiers3.ToString();
            foodWorkers2UI = gcValues.foodWorkers3.ToString();
            TextBox.GetComponent<Text>().text = "W " + foodWorkers2UI + " S " + foodSoldiers2UI;
        }

        else if (TextBox.tag == "foodNodeTxt3")
        {
            foodSoldiers3UI = gcValues.foodSoldiers4.ToString();
            foodWorkers3UI = gcValues.foodWorkers4.ToString();
            TextBox.GetComponent<Text>().text = "W " + foodWorkers3UI + " S " + foodSoldiers3UI;
        }

        else if (TextBox.tag == "foodNodeTxt4")
        {
            foodSoldiers4UI = gcValues.foodSoldiers5.ToString();
            foodWorkers4UI = gcValues.foodWorkers5.ToString();
            TextBox.GetComponent<Text>().text = "W " + foodWorkers4UI + " S " + foodSoldiers4UI;
        }

        else if (TextBox.tag == "waterNodeTxt0")
        {
            waterSoldiersUI = gcValues.waterSoldiers1.ToString();
            waterWorkersUI = gcValues.waterWorkers1.ToString();
            TextBox.GetComponent<Text>().text = "W " + waterWorkersUI + " S " + waterSoldiersUI;
        }

        else if (TextBox.tag == "waterNodeTxt1")
        {
            waterSoldiers1UI = gcValues.waterSoldiers2.ToString();
            waterWorkers1UI = gcValues.waterWorkers2.ToString();
            TextBox.GetComponent<Text>().text = "W " + waterWorkers1UI + " S " + waterSoldiers1UI;
        }

        else if (TextBox.tag == "waterNodeTxt2")
        {
            waterSoldiers2UI = gcValues.waterSoldiers3.ToString();
            waterWorkers2UI = gcValues.waterWorkers3.ToString();
            TextBox.GetComponent<Text>().text = "W " + waterWorkers2UI + " S " + waterSoldiers2UI;
        }

        else if (TextBox.tag == "waterNodeTxt3")
        {
            waterSoldiers3UI = gcValues.waterSoldiers4.ToString();
            waterWorkers3UI = gcValues.waterWorkers4.ToString();
            TextBox.GetComponent<Text>().text = "W " + waterWorkers3UI + " S " + waterSoldiers3UI;
        }

        else if (TextBox.tag == "waterNodeTxt14")
        {
            waterSoldiers4UI = gcValues.waterSoldiers5.ToString();
            waterWorkers4UI = gcValues.waterWorkers5.ToString();
            TextBox.GetComponent<Text>().text = "W " + waterWorkers4UI + " S " + waterSoldiers4UI;
        }
        else if (TextBox.tag == "defNodeTxt0")
        {
            defenseSoldiersUI = gcValues.defenseSoldiers1.ToString();
            defenseWorkersUI = gcValues.defenseWorkers1.ToString();
            TextBox.GetComponent<Text>().text = "W " + defenseWorkersUI + " S " + defenseSoldiersUI;
        }

        else if (TextBox.tag == "defNodeTxt1")
        {
            defenseSoldiers1UI = gcValues.defenseSoldiers2.ToString();
            defenseWorkers1UI = gcValues.defenseWorkers2.ToString();
            TextBox.GetComponent<Text>().text = "W " + defenseWorkers1UI + " S " + defenseSoldiers1UI;
        }

        else if (TextBox.tag == "defNodeTxt2")
        {
            defenseSoldiers2UI = gcValues.defenseSoldiers3.ToString();
            defenseWorkers2UI = gcValues.defenseWorkers3.ToString();
            TextBox.GetComponent<Text>().text = "W " + defenseWorkers2UI + " S " + defenseSoldiers2UI;
        }

        else if (TextBox.tag == "defNodeTxt3")
        {
            defenseSoldiers3UI = gcValues.defenseSoldiers4.ToString();
            defenseWorkers3UI = gcValues.defenseWorkers4.ToString();
            TextBox.GetComponent<Text>().text = "W " + defenseWorkers3UI + " S " + defenseSoldiers3UI;
        }

        else if (TextBox.tag == "defNodeTxt4")
        {
            defenseSoldiers4UI = gcValues.defenseSoldiers5.ToString();
            defenseWorkers4UI = gcValues.defenseWorkers5.ToString();
            TextBox.GetComponent<Text>().text = "W " + defenseWorkers4UI + " S " + defenseSoldiers4UI;
        }

    }


}
