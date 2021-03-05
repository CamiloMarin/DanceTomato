using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public  int col_Izq = 0;
    public  int col_Cen = 0;
    public  int col_Der = 0;
    public Animator anim;
    public bool golpeado = false;
    





    // Dercha

    public GameObject boton_Der;
    public Btn_Right classBtn_Right;

    // Centro

    public GameObject boton_Cen;
    public Btn_Center classBtn_Center;

    // Izquierda

    public GameObject boton_Izq;
    public Btn_Left classBtn_Left;

    void Start()
    {
        classBtn_Right = boton_Der.GetComponent<Btn_Right>();
        classBtn_Center = boton_Cen.GetComponent<Btn_Center>();
        classBtn_Left = boton_Izq.GetComponent<Btn_Left>();      
        anim = GetComponent<Animator>();
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BoxCollider_Izq")
        {
            col_Izq = 1;
            anim.SetTrigger("isTapped_Izquierda");
        } 


        if (other.gameObject.name == "BoxCollider_Cen")
        {
            col_Cen = 1;
            anim.SetTrigger("Idle/Center");
        } 

       

        if (other.gameObject.name == "BoxCollider_Der")
        {
            col_Der = 1;
            anim.SetTrigger("isTapped_Derecha");
        }


       



    }

    private void OnTriggerExit(Collider otherObj)

    {
        if (otherObj.gameObject.name == "BoxCollider_Izq")
        {
            col_Izq = 0;
            
        }


        if (otherObj.gameObject.name == "BoxCollider_Cen")
        {
            col_Cen = 0;
        }



        if (otherObj.gameObject.name == "BoxCollider_Der")
        {
            col_Der = 0;
        }

    }


    void Update()
    {

        
    }
}
