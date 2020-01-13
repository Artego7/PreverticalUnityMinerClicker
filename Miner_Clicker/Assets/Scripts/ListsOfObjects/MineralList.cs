﻿using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MineralList : MonoBehaviour
{

    [SerializeField]
    GameObject prefabTool;
    [SerializeField]
    GameObject content;

    Image imgPF;
    Text nameMineral;
    Text numOfMineral;

    Mineral mineral;

    string[] mineralName=
    {
        "Wood",
        "Rock",
        "Iron",
        "Gold",
        "Diamond"
    };

    public List<Mineral> minerals = new List<Mineral>();

    private void Start()
    {
        //Debug.Log(worldNames[0]);
        //world.Print();
        mineral = Resources.Load<Mineral>("ScriptableObj/Minerals/" + mineralName[0]);
        minerals.Add(mineral);
        for (int i = 1; i < mineralName.Length; i++)
        {
//#if UNITY_EDITOR
//            mineral = (Mineral)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Minerals/" + mineralName[i] + ".asset", typeof(Mineral));
//#endif
            mineral = Resources.Load<Mineral>("ScriptableObj/Minerals/" + mineralName[i]);
            //print(mineral);
            minerals.Add(mineral);
            //print(mineral);
            //minerals[i].Print();
            prefabTool.GetComponent<SumNumOfMinerals>().numOfMineral = minerals[i].numOfMineral;
            prefabTool.GetComponent<SumNumOfMinerals>().id= minerals[i].id;
            //prefabTool.GetComponent<Image>().sprite = minerals[i].imageMineralSprite;
            imgPF = prefabTool.transform.GetChild(0).GetComponent<Image>();
            nameMineral = prefabTool.transform.GetChild(1).GetComponent<Text>();
            numOfMineral = prefabTool.transform.GetChild(2).GetComponent<Text>();
            imgPF.sprite = minerals[i].imageMineralIcon;
            nameMineral.text = minerals[i].mineralname;
            numOfMineral.text = minerals[i].numOfMineral.ToString();
            Instantiate(prefabTool, content.transform);
        }
        mineral = minerals[0];

    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
