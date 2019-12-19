using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WorldControler : MonoBehaviour
{
    public static WorldControler instance;

    [SerializeField]
    public World world;

    List<World> worlds = new List<World>();

    string[] worldNames =
    {
        "Earth",
        "Marth",
        "Jupiter"
    };


    private void Awake()
    {
        //Debug.Log(worldNames[0]);
        instance = this;
        //world.Print();
        for (int i = 0; i < worldNames.Length; i++)
        {
            world = (World)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Worlds/" + worldNames[i] + ".asset", typeof(World));
            //world.Print();
            worlds.Add(world);
            //worlds[i].Print();
        }
        //Object[] wa = Resources.LoadAll("ScriptableObj/Worlds",typeof(World));
        world = worlds[0];

        //World w = (World)wa[0];
        //w.Print();
        //wa.Print();
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

}
