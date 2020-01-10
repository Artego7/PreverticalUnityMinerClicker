using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumNumOfMinerals : MonoBehaviour
{
    public int id;
    public int numOfMineral;

    GameObject gameControler;

    private void Awake()
    {
        gameControler = GameObject.Find("GameControler");
    }
        // Start is called before the first frame update
    void Start()
    {
        print(gameControler.GetComponent<GameControler>().numOfMineral(id));
    }

    // Update is called once per frame
    void Update()
    {
        if(numOfMineral != gameControler.GetComponent<GameControler>().numOfMineral(id))
        {
            this.transform.GetChild(2).GetComponent<Text>().text = 
                gameControler.GetComponent<GameControler>().numOfMineral(id).ToString();
            numOfMineral = gameControler.GetComponent<GameControler>().numOfMineral(id);
        }
            
    }
}
