using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tool", menuName = "Tool/Create", order = 1)]
public class Tool : ScriptableObject
{
    public int id;
    public string tool;
    public int hardness;
    public int durability;
    public int hability;

    public Material materialPickaxe;
    public Material materialPickaxeStick;
    //TEMPORAL VARIABLE
    public float RColorPickaxe;
    public float GColorPickaxe;
    public float BColorPickaxe;
    public float AColorPickaxe;

    public Sprite spriteIcon;
    Sprite imageTool;

    public Tool(int id_, string tool_, int hardness_, int durability_, int hability_, Sprite imageTool_)
    {
        id = id_;
        tool = tool_;
        hardness = hardness_;
        durability = durability_;
        hability = hability_;
        imageTool = imageTool_;
    }
    public int getIdTool()
    {
        return id;
    }
    public string getNameTool()
    {
        return tool;
    }

    public void Print()
    {
        Debug.Log("id: " + id + ", name: " + tool +
            ", hardness: " + hardness + ", durability: "
            + durability + ", R Color: " + RColorPickaxe +
            ", G Color: " + GColorPickaxe + ", B Color: " +
            BColorPickaxe + ", A Color: " + AColorPickaxe
            );

    }

}
