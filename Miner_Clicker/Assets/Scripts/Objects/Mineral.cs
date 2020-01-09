using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mineral", menuName = "Mineral/Create", order = 1)]
public class Mineral : ScriptableObject
{
    //General
    public int id;
    public string mineralname;
    public int hardness;

    //Mining
    public int probabilityAppear;

    //Fundation
    public int timeToFoundation;
    public int chanceOfSmelting;

    //Visual
    public Sprite imageMineralIcon;
    public Sprite imageMineralSprite;

    public Mineral(int id_, string mineral_, int hardness_, int probabilityAppear_, int timeToFoundation_,
                    int chanceOfSmelting_, Sprite imageMineralSprite_, Sprite imageMineralIcon_)
    {
        id = id_;
        mineralname = mineral_;
        hardness = hardness_;
        probabilityAppear = probabilityAppear_;
        timeToFoundation = timeToFoundation_;
        chanceOfSmelting = chanceOfSmelting_;
        //imageMineralSprite = imageMineralSprite_;
        imageMineralIcon = imageMineralIcon_;
    }
    
    public int getIdMineral()
    {
        return id;
    }
    public string getNameMineral()
    {
        return mineralname;
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
