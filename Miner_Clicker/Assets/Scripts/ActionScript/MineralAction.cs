using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineralAction : MonoBehaviour
{
    [SerializeField]
    Text textShowMineral;
    [SerializeField]
    Image imgDirability;

    Mineral mineral;
    Renderer cubeRenderer;
    World world;
    Animator animator;

    Player player;
    PickaxeAction pickaxeAction;

    GameObject gameControler;

    float actualHardness;
    bool isMining = false;


    private void Awake()
    {
        gameControler = GameObject.Find("GameControler");
        world = GameControler.instance.world;
        player = GameControler.instance.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        pickaxeAction = FindObjectOfType<PickaxeAction>();

        cubeRenderer = this.gameObject.GetComponent<Renderer>();
        animator = this.gameObject.GetComponent<Animator>();

        mineral = world.minerals[Random.RandomRange(0, world.minerals.Count - 1)];//Random.RandomRange(0,3)
        //print(world.minerals.Count - 1);
        cubeRenderer.material.SetTexture("_MainTex", mineral.imageMineralSprite.texture);

        actualHardness = mineral.hardness;
        textShowMineral.text = mineral.mineralname;
        //print(player.pickaxeOnUse);
    }

    // Update is called once per frame
    void Update()
    {
        if (isMining && !Input.GetMouseButtonDown(0))
        {
            pickaxeAction.animPickaxeFalse();
            animator.SetBool("IsMining", false);
            isMining = !isMining;;
        }
    }
    private void OnMouseDown()
    {
        gameControler.GetComponent<GameControler>().emitParticlesClick();
        if (!isMining)
        {
            pickaxeAction.animPickaxeTrue();
            animator.SetBool("IsMining", true);
            isMining = !isMining;
        }

        actualHardness -= player.tools[player.pickaxeOnUse].hardness;
        imgDirability.fillAmount = actualHardness / mineral.hardness;
        //print(actualHardness / mineral.hardness);

        if (actualHardness <= 0)
        {
            mineral.numOfMineral++;
            Invoke("instanceFunctGC", 0.1f);
            Destroy(gameObject, 0.1f);
        }
        Debug.Log(actualHardness);
    }
    void instanceFunctGC()
    {
        gameControler.GetComponent<GameControler>().instanceMineral();
    }
}
//www.youtube.com/watch?v=iFKzXnIiH50