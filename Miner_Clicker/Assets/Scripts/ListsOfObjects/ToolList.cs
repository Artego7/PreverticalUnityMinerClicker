using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ToolList : MonoBehaviour
{
    [SerializeField]
    GameObject prefabTool;
    [SerializeField]
    GameObject content;

    Text textPF;
    Image imgPF;

    Tool tool;

    //public static ToolList instance;


    public List<Tool> tools = new List<Tool>();

    string[] toolNames =
    {
        "WoodPickaxe",
        "RockPickaxe",
        "IronPickaxe",
        "GoldPickaxe",
        "DiamondPickaxe"
    };

    private void Start()
    {
        //Debug.Log(worldNames[0]);
        //world.Print();
        for (int i = 0; i < toolNames.Length; i++)
        {
//#if UNITY_EDITOR
//            tool = (Tool)AssetDatabase.LoadAssetAtPath("Assets/ScriptableObj/Tools/" + toolNames[i] + ".asset", typeof(Tool));
//#endif
            tool = Resources.Load<Tool>("ScriptableObj/Tools/" + toolNames[i]);
            tools.Add(tool);
            //tools[i].Print();
            prefabTool.GetComponent<ChangePickaxe>().id = tools[i].id;
            prefabTool.GetComponent<ChangePickaxe>().isBuyed = tools[i].isBuyed;
            prefabTool.GetComponent<Image>().color = new Color(tools[i].RColorPickaxe / 255, 
                                                                tools[i].GColorPickaxe / 255, 
                                                                tools[i].BColorPickaxe / 255, 
                                                                tools[i].AColorPickaxe / 255);
            textPF = prefabTool.GetComponentInChildren<Text>();
            imgPF = prefabTool.transform.GetChild(0).GetComponent<Image>();
            imgPF.sprite = tools[i].spriteIcon;
            textPF.text = tools[i].tool;
            Instantiate(prefabTool, content.transform);
        }
        tool = tools[0];

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
