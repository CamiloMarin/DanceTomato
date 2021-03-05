using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Play : MonoBehaviour
{
    
    public GameObject DPlayer;
    private Transform xAxis_DPlayer;
    public player script_player;
    public ParticleSystem tomatoHit;
    public ParticleSystem death1;
    public ParticleSystem death2;
    public ParticleSystem death3;
    int[] variables = new int[3] { 1, 2, 3 };
    public int result = 0;
    bool runOnce = false;
    public CameraShake cameraShake;


    void Start()
    {
        script_player = DPlayer.GetComponent<player>();
        xAxis_DPlayer = DPlayer.GetComponent<Transform>();

        ParticleSystem tomatoHit = GetComponent<ParticleSystem>();
        ParticleSystem death1 = GetComponent<ParticleSystem>();
        ParticleSystem death2 = GetComponent<ParticleSystem>();
        ParticleSystem death3 = GetComponent<ParticleSystem>();
        result = variables[Random.Range(0, variables.Length)];        
        runOnce = false;
        
    }

    
    void Update()
    {

        transform.position = new Vector3(xAxis_DPlayer.position.x, transform.position.y, transform.position.z);

        if (!DPlayer.activeSelf && !runOnce)
        {
            PlayParticles();
            StartCoroutine(cameraShake.Shake());
            runOnce = true;
        }
       
        


    }


    


    public void PlayParticles()
    {
        


            tomatoHit.Stop();

            if (tomatoHit.isStopped)
            {
                tomatoHit.Play();

            }


            if (result == 1)
            {

                death1.Stop();
                if (death1.isStopped)
                {
                    death1.Play();
                }

            }
            if (result == 2)
            {
                death2.Stop();
                if (death2.isStopped)
                {
                    death2.Play();
                }
            }
            if (result == 3)
            {
                death3.Stop();
                if (death3.isStopped)
                {
                    death3.Play();
                }
            }

            

        

    }


}
