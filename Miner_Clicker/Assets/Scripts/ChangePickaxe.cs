using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePickaxe : MonoBehaviour
{

    public Player player;
    public int id;
    public bool isChange = false;

    private void Awake()
    {
        player = GameControler.instance.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changePickaxe()
    {
        player.pickaxeOnUse = player.tools[id].id;
        isChange = true;
    }
}
