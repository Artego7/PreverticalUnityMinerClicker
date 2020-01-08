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

    ChangePickaxe changePickaxe;

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
        if (changePickaxe.isChange)
        {
            player.pickaxeOnUse = changePickaxe.player.pickaxeOnUse;
            changePickaxe.isChange = false;
        }
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

}
