using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralAction : MonoBehaviour
{
    [SerializeField]
    Mineral mineral;
    Renderer cubeRenderer;
    int actualHardness;
    World world;

    private void Awake()
    {
        world = WorldControler.instance.world;
    }
    // Start is called before the first frame update
    void Start()
    {
        actualHardness = mineral.hardness;
        cubeRenderer = this.gameObject.GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        actualHardness--;
        actualHardness = mineral.hardness;
        if (actualHardness <= mineral.hardness / 2)
        cubeRenderer.material.SetColor("_Color", Color.yellow);
        if (actualHardness <= mineral.hardness / 4)
            cubeRenderer.material.SetColor("_Color", Color.red);
        if (actualHardness <= 0)
            Destroy(gameObject);
    }
    void getData()
    {

    }
}
//www.youtube.com/watch?v=iFKzXnIiH50