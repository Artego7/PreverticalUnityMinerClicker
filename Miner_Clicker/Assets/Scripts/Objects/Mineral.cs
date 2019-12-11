using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mineral
{
    //General
    int id;
    string name;
    int hardness;

    //Mining
    int probabilityAppear;
    
    //Fundation
    int timeToFoundation;
    int chanceOfSmelting;

    //Visual
    string imageMineralOre;
    string imageMineral;

    public Mineral(int id_, string name_, int hardness_, int probabilityAppear_, int timeToFoundation_, 
                    int chanceOfSmelting_, string imageMineralOre_, string imageMineral_)
    {
        id = id_;
        name = name_;
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
        return name;
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
}
