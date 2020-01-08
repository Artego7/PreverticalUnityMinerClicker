using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralControler : MonoBehaviour
{

    [SerializeField]
    GameObject prefabMineral;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabMineral);
        //Debug.Log(prefabMineral);
    }

    // Update is called once per frame
    void Update()
    {
        if(prefabMineral == null)
            Instantiate(prefabMineral);
        if (Input.GetKeyDown(KeyCode.S))
            Instantiate(prefabMineral);
    }
    public void instanceMineral()
    {
        //Debug.Log(prefabMineral);
    }
}
