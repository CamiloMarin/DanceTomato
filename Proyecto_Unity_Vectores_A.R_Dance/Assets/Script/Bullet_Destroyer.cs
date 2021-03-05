using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet_Destroyer : MonoBehaviour
{
    public ParticleSystem tomato_Destroy;
    public GameObject bulletObj;
    private bool isOn = false;
    
    


    void Start()
    {
        ParticleSystem tomato_Destroy = GetComponent<ParticleSystem>();
        
        
    }

    
    void Update()
    {
        if (isOn)
        {
            StartCoroutine(TomatoEjecution());
           
        }

       
    }


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pared")
        {

            isOn = true;


        }

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);            
            Destroy(this.gameObject);
            
        }

    }


    IEnumerator TomatoEjecution()
    {
        tomato_Destroy.Stop();

        if (tomato_Destroy.isStopped)
        {
            tomato_Destroy.Play();
            
        }

       
        // Code before the pause
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
 

    }


    

}
