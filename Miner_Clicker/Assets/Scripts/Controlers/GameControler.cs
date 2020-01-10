using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
    //ParticleClick
    [SerializeField]
    ParticleSystem ps;
    //Audio
    [SerializeField]
    AudioClip basicPickaxeSound;
    [SerializeField]
    AudioSource audioSource;


    List<World> worlds = new List<World>();
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
        Instantiate(prefabMineral);
        minerals = mineralList.minerals;
        audioSource.clip = basicPickaxeSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (prefabMineral == null)
            print("hola");
        if (Input.GetKeyDown(KeyCode.C))
            print(prefabMineral);
        if (Input.GetKeyDown(KeyCode.S))
            instanceMineral();
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
}
