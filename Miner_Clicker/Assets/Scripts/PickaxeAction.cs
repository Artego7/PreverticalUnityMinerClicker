using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeAction : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animPickaxeTrue(){
            animator.SetBool("IsMining", true);
    }
    public void animPickaxeFalse()
    {
        animator.SetBool("IsMining", true);
    }

}
