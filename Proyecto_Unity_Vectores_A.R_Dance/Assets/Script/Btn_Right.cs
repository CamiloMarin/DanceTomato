using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn_Right : MonoBehaviour, IPointerDownHandler
{
    public bool isPressedR = false;
    public GameObject DPlayer;
    public Button rightButton;
    public Button leftButton;
    public player varDer;
    public Animator anim;
    float lastClick = 0f;
    float interval = 0.4f;


    public void SiTodaviaNoSeHaTerminadoLaAnimacion()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Desplazamiento_Derecha_Centro") &&
            anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {

            rightButton.interactable = false;
            leftButton.interactable = false;


        }
        else
        {
            rightButton.interactable = true;
            leftButton.interactable = true;
        }

    }


        void Start()

    {

        Button btn = rightButton.GetComponent<Button>();
        Button left_btn = leftButton.GetComponent<Button>();
        varDer = DPlayer.GetComponent<player>();
        anim = DPlayer.GetComponent<Animator>();

    }


    void Update()
    {

        if (varDer.col_Der == 0 && varDer.col_Cen == 1)
        {


            SiTodaviaNoSeHaTerminadoLaAnimacion();



        }

 
        if (varDer.col_Der == 1)

        {
            rightButton.interactable = false;
            leftButton.interactable = false;

        }

       

    }





    public void OnPointerDown(PointerEventData eventData)
    {
        isPressedR = true;
      

        if ((lastClick + interval) > Time.time)
        {

            rightButton.enabled = false;

        }
        else
        {
            rightButton.enabled = true;
        }

        lastClick = Time.time;


    }

    
    



    public void OnClick_To_Right()
    {
        if (isPressedR)
        {
            anim.ResetTrigger("Idle/Center");
            anim.SetTrigger("isTapped_DeCentro_Derecha");
            isPressedR = false;
            


        }

     
    }

}
