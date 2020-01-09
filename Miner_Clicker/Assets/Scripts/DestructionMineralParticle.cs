using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionMineralParticle : MonoBehaviour
{
    ParticleSystem ps;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
        //ps.Pause();
        //Debug.Log(ps.isPaused);
        //Debug.Log(ps.main.duration);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        //if (Input.GetMouseButtonDown(0) && ps.isPaused)
        //{
        //    Debug.Log("Play = " + ps.isPaused);
        //    ps.Play();
        //}


        //if (ps.isPlaying && currentTime >= ps.main.duration * 60)
        //{
        //    ps.Pause();
        //    Debug.Log("Pausado = " + ps.isPaused);
        //}
    }
}
