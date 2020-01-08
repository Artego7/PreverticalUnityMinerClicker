using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeSound : MonoBehaviour
{
    [SerializeField]
    AudioClip basicPickaxeSound;
    [SerializeField]
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = basicPickaxeSound;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        audioSource.Play();
    }
    private void OnMouseDown()
    {
        
    }
}
