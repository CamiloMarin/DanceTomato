using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn_Left : MonoBehaviour, IPointerDownHandler
{
    public bool isPressedL = false;
    public GameObject DPlayer;
    public Button LeftButton;
    public Button RightButton;
    public player varIzq;
    public Animator anim;
    float lastClick = 0f;
    float interval = 0.4f;



    public void SiTodaviaNoSeHaTerminadoLaAnimacion()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Desplazamiento_Izquierda_Centro") &&
            anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {

            LeftButton.interactable = false;
            RightButton.interactable = false;
        }
        else
        {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        }

    }



    void Start()
    {
        Button btn = LeftButton.GetComponent<Button>();
        Button right_btn = RightButton.GetComponent<Button>();
        varIzq = DPlayer.GetComponent<player>();
        anim = DPlayer.GetComponent<Animator>();
    }


    void Update()
    {
        if (varIzq.col_Izq == 0 && varIzq.col_Cen == 1)
        {
            SiTodaviaNoSeHaTerminadoLaAnimacion();


        }
        if (varIzq.col_Izq == 1)
        {
            LeftButton.interactable = false;
            RightButton.interactable = false;
             

        }
        

    }



    public void OnPointerDown(PointerEventData eventData)
    {
        isPressedL = true;


        if ((lastClick + interval) > Time.time)
        {

            LeftButton.enabled = false;

        }
        else
        {
            LeftButton.enabled = true;
        }

        lastClick = Time.time;

    }

   

    public void OnClick_To_Left()
    {
        if (isPressedL)
        {
            anim.ResetTrigger("Idle/Center");
            anim.SetTrigger("isTapped_DeCentro_Izquierda");
            isPressedL = false;

        }
        
    }

}
