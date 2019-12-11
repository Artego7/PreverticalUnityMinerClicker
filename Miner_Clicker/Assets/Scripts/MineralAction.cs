using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralAction : MonoBehaviour
{
    Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        cubeRenderer.material.SetColor("_Color", Color.red);
    }

    private void OnMouseUp()
    {
        cubeRenderer.material.SetColor("_Color", Color.blue);
    }
}
//www.youtube.com/watch?v=iFKzXnIiH50