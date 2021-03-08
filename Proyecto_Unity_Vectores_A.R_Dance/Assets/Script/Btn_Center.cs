using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn_Center : MonoBehaviour, IPointerDownHandler
{
    public bool isPressedC = false;

    public GameObject DPlayer;
    public Button centerButton;
    public player varCen;
    public Animator anim;
    float lastClick = 0f;
    float interval = 0.4f;



    void Start()
    {
        Button btn = centerButton.GetComponent<Button>();
        varCen = DPlayer.GetComponent<player>();
        anim = DPlayer.GetComponent<Animator>();
    }


    void Update()
    {
        if (varCen.col_Cen == 1)
        {
            isPressedC = false;
            centerButton.interactable = false;
            

        }

        

        if (varCen.col_Der == 1 )
        {
           
            centerButton.interactable = true;

        }

        if (varCen.col_Izq == 1)
        {
           
            centerButton.interactable = true;
            
        }

       



    }



    public void OnPointerDown(PointerEventData eventData)
    {
        isPressedC = true;
        
        

        if ((lastClick + interval) > Time.time)
        {

            centerButton.enabled = false;

        }
        else
        {
            centerButton.enabled = true;
        }

        lastClick = Time.time;


    }


    


        

    public void OnClick_Center()

    {
        if (isPressedC && varCen.col_Der == 1)
        {
            anim.ResetTrigger("isTapped_Derecha");
            anim.SetTrigger("isTapped_DeDerecha_Centro");
            isPressedC = false;

            if (anim.GetCurrentAnimatorStateInfo(0).length < anim.GetCurrentAnimatorStateInfo(0).normalizedTime)
            {
                anim.SetTrigger("Idle/Center");
            }
            

           



        }
        else if (isPressedC && varCen.col_Izq == 1)
        {
            anim.ResetTrigger("isTapped_Izquierda");
            anim.SetTrigger("isTapped_DeIzquierda_Centro");
            isPressedC = false;

           if (anim.GetCurrentAnimatorStateInfo(0).length < anim.GetCurrentAnimatorStateInfo(0).normalizedTime)
            {

                anim.SetTrigger("Idle/Center");
            }

        }



    }

   
    


}
