using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;

// Editor stuff here
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameControler : MonoBehaviour
{
    public static GameControler instance;
    [SerializeField]
    GameObject prefabMineral;
    [SerializeField]
    public World world;
    [SerializeField]
    PlayerAction playerAction;
    [SerializeField]
    public Player player;
    [SerializeField]
    GameObject Pickaxe;
    [SerializeField]
    MineralList mineralList;
    [SerializeField]
    ToolList toolList;
    //ParticleClick
    [SerializeField]
    ParticleSystem ps;
    //Audio
    [SerializeField]
    AudioClip basicPickaxeSound;
    [SerializeField]
    AudioSource audioSource;


    List<World> worlds = new List<World>();
    List<Tool> tools = new List<Tool>();
    public List<Mineral> minerals = new List<Mineral>();
    string[] worldNames =
    {
        "Earth",
        "Mars",
        "Jupiter"
    };


    private void Awake()
    {
        instance = this;
        for (int i = 0; i < worldNames.Length; i++)
        {
//#if UNITY_EDITOR
//            world = (World)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Worlds/" + worldNames[i] + ".asset", typeof(World));
//#endif
            world = Resources.Load<World>("ScriptableObj/Worlds/" + worldNames[i]);
            worlds.Add(world);
        }
        world = worlds[0];
        player = playerAction.player;
        Instantiate(prefabMineral);
    }
    // Start is called before the first frame update
    void Start()
    {
        minerals = mineralList.minerals;
        tools = toolList.tools;
        audioSource.clip = basicPickaxeSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (prefabMineral == null)
            print("hola");
        if (Input.GetKeyDown(KeyCode.C))
        if (Input.GetKeyDown(KeyCode.S))
            instanceMineral();
        if (Input.GetKeyDown(KeyCode.A))
            Admin();
        if (Input.GetKeyDown(KeyCode.R))
            ResetMinerals();
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

    }
    public void instanceMineral()
    {
        Instantiate(prefabMineral);
    }
    public void sumNumOfMineral(int id, int num)
    {
        minerals[id].numOfMineral = num;
    }
    public int numOfMineral(int id)
    {
        return minerals[id].numOfMineral;
    }
    public void emitParticlesClick()
    {
        ps.Emit(7);
        audioSource.Play();
    }
    public bool buyPickaxe(int id)
    {
            print(id);
                print(minerals[id].id + " " + tools[id].id);
        if(minerals[id].numOfMineral >= tools[id].priceForBuy)
        {
            //print(minerals[id].numOfMineral);
            //print(tools[id].priceForBuy);
            //if(id == 0)
            minerals[id].numOfMineral -= tools[id].priceForBuy;
            //if (id > 0)
            //{
            //    minerals[id-1].numOfMineral -= tools[id].priceForBuy;
            //}

            return true;
        }
        return false;
    }


    //ADMIN
    public void Admin()
    {
        minerals[0].numOfMineral += 10;
        minerals[1].numOfMineral += 10;
        minerals[2].numOfMineral += 10;
        minerals[3].numOfMineral += 10;
        minerals[4].numOfMineral += 10;
    }
    public void ResetMinerals()
    {
        minerals[0].numOfMineral = 0;
        minerals[1].numOfMineral = 0;
        minerals[2].numOfMineral = 0;
        minerals[3].numOfMineral = 0;
        minerals[4].numOfMineral = 0;
    }
}
