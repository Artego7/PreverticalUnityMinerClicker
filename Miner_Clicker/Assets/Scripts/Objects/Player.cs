using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player/Create", order = 1)]
public class Player : ScriptableObject
{
    public string playerName;
    public List<Tool> tools;
    public List<Mineral> minerals;
    public int pickaxeOnUse;

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
