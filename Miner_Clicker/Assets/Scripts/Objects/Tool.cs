using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool
{
    int id;
    string name;
    int hardness;
    int durability;
    int hability;

    public Tool(int id_, string name_, int hardness_, int durability_, int hability_)
    {
        id = id_;
        name = name_;
        hardness = hardness_;
        durability = durability_;
        hability = hability_;
    }
    public int getIdTool()
    {
        return id;
    }
    public string getNameTool()
    {
        return name;
    }

}
