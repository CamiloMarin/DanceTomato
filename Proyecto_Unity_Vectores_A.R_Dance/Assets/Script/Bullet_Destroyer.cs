using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destroyer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pared")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }

}
