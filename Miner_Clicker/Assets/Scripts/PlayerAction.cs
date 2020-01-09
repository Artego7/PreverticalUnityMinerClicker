using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    public Player player;
    [SerializeField]
    GameObject Pickaxe;
    [SerializeField]
    ToolList toolList;

    // Start is called before the first frame update
    private void Awake()
    {
        player.playerName = "Vegetita";
        player.tools = toolList.tools;
        player.pickaxeOnUse = 0;
        for (int i = 0; i < player.tools.Count ; i++)
        //print(player.tools[i].tool);
        Pickaxe.transform.GetChild(1).GetComponent<Renderer>()
            .material.SetColor("_Color", new Color(player.tools[player.pickaxeOnUse].RColorPickaxe / 255,
                                        player.tools[player.pickaxeOnUse].GColorPickaxe / 255,
                                        player.tools[player.pickaxeOnUse].BColorPickaxe / 255,
                                        player.tools[player.pickaxeOnUse].AColorPickaxe / 255));
        print(player.tools[0].RColorPickaxe + " " + player.tools[player.pickaxeOnUse].GColorPickaxe + " " +
                                        player.tools[player.pickaxeOnUse].BColorPickaxe + " " +
                                        player.tools[player.pickaxeOnUse].AColorPickaxe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
