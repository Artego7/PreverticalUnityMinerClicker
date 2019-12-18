using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WorldControler : MonoBehaviour
{
    public static WorldControler instance;
    [SerializeField]
    public World world;

    List<World> worlds;

    private void Awake()
    {
        //worlds.Add();
    }
    // Start is called before the first frame update
    void Start()
    {

        instance = this;
        //world.Print();
        World weeorld = (World)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Worlds/Marth.asset",typeof(World));
        weeorld.Print();
        Object[] wesdfdsdf = Resources.LoadAll("ScriptableObj/Worlds",typeof(World));

        World w = (World)wesdfdsdf[0];
        w.Print();
        //wesdfdsdf.Print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
