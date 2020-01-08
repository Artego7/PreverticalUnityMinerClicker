using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineralAction : MonoBehaviour
{
    [SerializeField]
    Text textShowMineral;

    Mineral mineral;
    Renderer cubeRenderer;
    World world;
    Animator animator;

    Player player;
    
    MineralControler mControler;
    PickaxeAction pickaxeAction;

    int actualHardness;
    bool isMining = false;


    private void Awake()
    {
        world = GameControler.instance.world;
        player = GameControler.instance.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        pickaxeAction = FindObjectOfType<PickaxeAction>();
        mControler = FindObjectOfType<MineralControler>();

        cubeRenderer = this.gameObject.GetComponent<Renderer>();
        animator = this.gameObject.GetComponent<Animator>();

        //world.Print();
        mineral = world.minerals[Random.RandomRange(0,3)];
        actualHardness = mineral.hardness;
        textShowMineral.text = mineral.mineralname;
        //Debug.Log(mineral.hardness);
        //Debug.Log(mineral.mineralname);
        print(player.pickaxeOnUse);
    }

    // Update is called once per frame
    void Update()
    {
        if (isMining && !Input.GetMouseButtonDown(0))
        {
            pickaxeAction.animPickaxeFalse();
            animator.SetBool("IsMining", false);
            isMining = !isMining;
        }
    }
    private void OnMouseDown()
    {
        if (!isMining) {
            pickaxeAction.animPickaxeTrue();
            animator.SetBool("IsMining", true);
            isMining = !isMining;
        }
        actualHardness -= player.tools[player.pickaxeOnUse].hardness;
        if (actualHardness <= mineral.hardness / 2)
        cubeRenderer.material.SetColor("_Color", Color.yellow);
        if (actualHardness <= mineral.hardness / 4)
            cubeRenderer.material.SetColor("_Color", Color.red);
        if (actualHardness <= 0)
        {
            mControler.instanceMineral();
            Destroy(gameObject);
        }
        Debug.Log(actualHardness);
    }
}
//www.youtube.com/watch?v=iFKzXnIiH50