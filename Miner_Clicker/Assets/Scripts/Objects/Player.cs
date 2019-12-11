using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string name;
    Tool[] tools;
    Mineral[] minerals;

    public Player(string name_)
    {
        name = name_;
    }
    public void addTool(Tool tools_)
    {
        tools[tools_.getIdTool()] = tools_;
    }
    public void addTool(Mineral mineral_)
    {
        minerals[mineral_.getIdMineral()] = mineral_;
    }
}
