using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAction : MonoBehaviour
{
    ParticleSystem ps;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
        ps.Pause();
        //Debug.Log(ps.isPaused);
        //Debug.Log(ps.main.duration);

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Input.mousePosition;
    }
}
