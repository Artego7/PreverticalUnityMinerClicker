using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mineral", menuName = "Mineral/Create", order = 1)]
public class Mineral : ScriptableObject
{
    //General
    public int id;
    public string mineral;
    public int hardness;

    //Mining
    public int probabilityAppear;

    //Fundation
    public int timeToFoundation;
    public int chanceOfSmelting;

    //Visual
    public Sprite imageMineral;
    public Sprite imageMineralOre;

    public Mineral(int id_, string mineral_, int hardness_, int probabilityAppear_, int timeToFoundation_,
                    int chanceOfSmelting_, Sprite imageMineralOre_, Sprite imageMineral_)
    {
        id = id_;
        mineral = mineral_;
        hardness = hardness_;
        probabilityAppear = probabilityAppear_;
        timeToFoundation = timeToFoundation_;
        chanceOfSmelting = chanceOfSmelting_;
        imageMineralOre = imageMineralOre_;
        imageMineral = imageMineral_;
    }
    
    public int getIdMineral()
    {
        return id;
    }
    public string getNameMineral()
    {
        return mineral;
    }
    public int getProbabilityAppear()
    {
        return probabilityAppear;
    }
    public int getTimeToFoundation()
    {
        return timeToFoundation;
    }
    public int getChanceOfSmelting()
    {
        return chanceOfSmelting;
    }

    public void Print()
    {
        Debug.Log("id: " + id + ", name: " + name +", hardness: " + hardness +
            ", Probability Appear: " + probabilityAppear + ", Time to Foundation" + timeToFoundation +
            ", Chance of Smelting: " + chanceOfSmelting);
    }

}
