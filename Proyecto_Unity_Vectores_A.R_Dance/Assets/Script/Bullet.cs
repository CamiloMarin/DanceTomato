using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100.0f;
    private float timer = 2.0f;
    GameObject bullet_Clone;
    public float SpawnTimeHigh = 10f;
    public float SpawnTimeLow = 5f;

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
            timer = Random.Range(SpawnTimeLow, SpawnTimeHigh);
        }
        
    }
}
    

