using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralAction : MonoBehaviour
{
    Mineral mineral;
    Renderer cubeRenderer;
    MineralControler mControler;
    int actualHardness;
    World world;

    private void Awake()
    {
        world = WorldControler.instance.world;
    }
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = this.gameObject.GetComponent<Renderer>();
        mControler = gameObject.GetComponent<MineralControler>();
        world.Print();
        mineral = world.minerals[0];
        actualHardness = mineral.hardness;
        Debug.Log(mineral.hardness);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        actualHardness--;
        if (actualHardness <= mineral.hardness / 2)
        cubeRenderer.material.SetColor("_Color", Color.yellow);
        if (actualHardness <= mineral.hardness / 4)
            cubeRenderer.material.SetColor("_Color", Color.red);
        if (actualHardness <= 0)
        {
            Destroy(gameObject);

            mControler.instanceMineral();
        }

        Debug.Log(actualHardness);
    }
    void getData()
    {

    }
}
//www.youtube.com/watch?v=iFKzXnIiH50