using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public static GameControler instance;

    [SerializeField]
    public World world;
    [SerializeField]
    PlayerAction playerAction;
    [SerializeField]
    public Player player;
    [SerializeField]
    GameObject Pickaxe;

    List<World> worlds = new List<World>();

    string[] worldNames =
    {
        "Earth",
        "Marth",
        "Jupiter"
    };


    private void Awake()
    {
        instance = this;
        for (int i = 0; i < worldNames.Length; i++)
        {
            world = (World)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Worlds/" + worldNames[i] + ".asset", typeof(World));
            worlds.Add(world);
        }
        //Object[] wa = Resources.LoadAll("ScriptableObj/Worlds",typeof(World));
        world = worlds[0];
        player = playerAction.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoEarth()
    {
        world = worlds[0];
    }

    public void GoMarth()
    {
        world = worlds[1];
    }

    public void GoJupirt()
    {
        world = worlds[2];
    }
    public void changePickaxe(int pickaxe)
    {
        player.pickaxeOnUse = player.tools[pickaxe].id;
        Pickaxe.transform.GetChild(1).GetComponent<Renderer>()
            .material.SetColor("_Color", new Color(player.tools[player.pickaxeOnUse].RColorPickaxe/255,
                                        player.tools[player.pickaxeOnUse].GColorPickaxe/255,
                                        player.tools[player.pickaxeOnUse].BColorPickaxe/255,
                                        player.tools[player.pickaxeOnUse].AColorPickaxe/255));
        print(player.tools[0].RColorPickaxe + " " + player.tools[player.pickaxeOnUse].GColorPickaxe + " " +
                                        player.tools[player.pickaxeOnUse].BColorPickaxe + " " +
                                        player.tools[player.pickaxeOnUse].AColorPickaxe);

    }
}
