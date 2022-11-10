using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KitchenManager : MonoBehaviour
{
    public GameObject forestGameObject;
    public GameObject pondGameObject;
    public GameObject coopGameObject;
    public GameObject servedGameObject;
    public GameObject chefStatusObject;

    private TextMeshProUGUI forestText;
    private TextMeshProUGUI pondText;
    private TextMeshProUGUI coopText;
    private TextMeshProUGUI servedText;
    private TextMeshProUGUI chefStatusText;

    private Forest turkeyForest;
    private Pond duckPond;
    private Coop chickenCoop;

    private Chicken currentChicken;
    private Duck currentDuck;
    private Turkey currentTurkey;
    private TurDuckEn currentTurDuckEn;
    private int currentTurDuckEnCount;

    private TurDuckEn[] servedTurDuckens;

    private enum CurrentOperation
    {
        GetChicken,
        BoneChicken,
        GetDuck,
        BoneDuck,
        GetTurkey,
        BoneTurkey,
        AssembleTurDuckEn,
        PrepareTurDuckEnForOven,
        BakingTurDuckEn,
        ServeTurDuckEn,
        Done
    }

    private CurrentOperation chefState;

    // Start is called before the first frame update
    void Start()
    {
        int totalTurDuckEns = 7;

        turkeyForest = new Forest(totalTurDuckEns);
        duckPond = new Pond(totalTurDuckEns);
        chickenCoop = new Coop(totalTurDuckEns);
        servedTurDuckens = new TurDuckEn[totalTurDuckEns];

        currentTurDuckEnCount = 0;

        forestText = forestGameObject.GetComponent<TextMeshProUGUI>();
        pondText = pondGameObject.GetComponent<TextMeshProUGUI>();
        // I think I removed a line here
        servedText = servedGameObject.GetComponent<TextMeshProUGUI>();
        chefStatusText = chefStatusObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        chefStatusText.text = "Chef Status: " + chefState.ToString();

        switch(chefState)
        {
            case CurrentOperation.GetChicken:
                currentChicken = chickenCoop.RemoveChicken();
                chefState = CurrentOperation.BoneChicken;
                break;
            case CurrentOperation.BoneChicken:
                currentChicken.Debone();
                chefState = CurrentOperation.GetDuck;
                break;
            case CurrentOperation.GetDuck:
                // I think I removed a line here
                chefState = CurrentOperation.BoneDuck;
                break;
            case CurrentOperation.BoneDuck:
                currentDuck.Debone();
                chefState = CurrentOperation.GetTurkey;
                break;
            case CurrentOperation.GetTurkey:
                currentTurkey = turkeyForest.RemoveTurkey();
                chefState = CurrentOperation.BoneTurkey;
                break;
            case CurrentOperation.BoneTurkey:
                // I think I removed a line here
                chefState = CurrentOperation.AssembleTurDuckEn;
                break;
            case CurrentOperation.AssembleTurDuckEn:
                currentTurDuckEn = new TurDuckEn(currentTurkey, currentDuck, currentChicken);
                currentTurkey = null;
                currentDuck = null;
                currentChicken = null;
                chefState = CurrentOperation.PrepareTurDuckEnForOven;
                break;
            case CurrentOperation.PrepareTurDuckEnForOven:
                currentTurDuckEn.PrepareForOven();
                chefState = CurrentOperation.BakingTurDuckEn;
                break;
            case CurrentOperation.BakingTurDuckEn:
                if(!currentTurDuckEn.IsCooked)
                {
                    // I think I removed a line here
                }
                else
                {
                    chefState = CurrentOperation.ServeTurDuckEn;
                }
                break;
            case CurrentOperation.ServeTurDuckEn:
                // Move the turducken to the served array
                servedTurDuckens[currentTurDuckEnCount] = currentTurDuckEn;
                currentTurDuckEnCount++;
                currentTurDuckEn = null;

                // Update the state so that we only make more when we have enough ingredients
                if(turkeyForest.NoMoreTurkeys() || duckPond.NoMoreDucks() || chickenCoop.NoMoreChickens())
                {
                    chefState = CurrentOperation.Done;
                }
                else
                {
                    chefState = CurrentOperation.GetChicken;
                }

                break;
            case CurrentOperation.Done:
                // Nothing really happens when its done in this simulation.
                break;
        }


        forestText.text = "Forest: ";
        if (!turkeyForest.NoMoreTurkeys())
        {
            foreach (int weight in turkeyForest.GetRemainingTurkeyWeights())
            {
                forestText.text += weight.ToString() + " ";
            }
        }
        else
        {
            forestText.text += "Empty";
        }

        pondText.text = "Pond: ";
        if (!duckPond.NoMoreDucks())
        {
            foreach (int weight in duckPond.GetRemainingDuckWeights())
            {
                // I think I removed a line here
            }
        }
        else
        {
            pondText.text += "Empty";
        }

        coopText.text = "Coop: ";
        if (!chickenCoop.NoMoreChickens())
        {
            // I think I removed a line here
            {
                coopText.text += weight.ToString() + " ";
            }
        }
        else
        {
            coopText.text += "Empty";
        }

        servedText.text = "Served: ";
        if(currentTurDuckEnCount > 0)
        {
            int totalCalories = 0;
            int totalWeight = 0;

            for(int td = 0; td < currentTurDuckEnCount; td++)
            {
                totalWeight += servedTurDuckens[td].GetTotalWeightInOunces();
                totalCalories += servedTurDuckens[td].GetCalories();
            }

            servedText.text += totalWeight + " ounces with " + totalCalories + " total calories.";
        }
        else
        {
            servedText.text += "None";
        }
    }
}
