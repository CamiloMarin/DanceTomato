using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100.0f;
    public float timer = 2.0f;
    GameObject bullet_Clone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            bullet_Clone = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            bullet_Clone.transform.localRotation = Quaternion.Euler(new Vector3(Random.Range(0f, 360f), 0, Random.Range(0f, 360f)));
            Rigidbody inst_Bullet_RB = bullet_Clone.GetComponent<Rigidbody>();
            inst_Bullet_RB.AddForce(Vector3.forward * speed);
            timer = 2;
        }
        
    }
}
    

