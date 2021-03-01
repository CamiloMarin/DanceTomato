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
           // centerButton.enabled = true;
            centerButton.interactable = true;

        }

        if (varCen.col_Izq == 1)
        {
           // centerButton.enabled = true;
            centerButton.interactable = true;
            
        }

        if (isPressedC == false && varCen.col_Cen == 0 && varCen.col_Der == 1)
        {
            // anim.SetTrigger("isTapped_DeDerecha_Centro");

        }

        if (isPressedC == false && varCen.col_Cen == 0 && varCen.col_Izq == 1)
        {
            // anim.SetTrigger("isTapped_DeDerecha_Centro");

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

    
    

    public void OnClick_Center_To_Right()

    {
        if (isPressedC && varCen.col_Der == 1)
        {
            
            anim.SetTrigger("isTapped_DeDerecha_Centro");
            isPressedC = false;

            
        }

       

    }

    public void OnClick_Center_To_Left()
    {
        if (isPressedC && varCen.col_Izq == 1)
        {

            anim.SetTrigger("isTapped_DeIzquierda_Centro");
            isPressedC = false;

           

        }


    }

    


}
