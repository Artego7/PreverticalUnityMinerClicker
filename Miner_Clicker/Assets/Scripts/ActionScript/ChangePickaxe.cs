using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePickaxe : MonoBehaviour
{

    public Player player;
    public int id;
    public bool isBuyed;
    GameObject gameControler;


    private void Awake()
    {
        gameControler = GameObject.Find("GameControler");

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

    public void change()
    {
        if (gameControler.GetComponent<GameControler>().buyPickaxe(id) && !isBuyed)
            isBuyed = true;

        if (isBuyed)
            gameControler.GetComponent<GameControler>().changePickaxe(id);
    }
}
