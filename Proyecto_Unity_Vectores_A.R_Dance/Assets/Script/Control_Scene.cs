using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control_Scene : MonoBehaviour
{
    // Objeto balas
    public GameObject lanzador_balas;



    // Text
    public Text smash_bros_UI;
    public GameObject text_smash_bros;
    public Animator anim_text;

    // Text Anim
    public Animator anim_Restart;


    // UI Lose / UI Restart

    public Animator anim_Lose;
    public GameObject UI_Image_Restart;
    public GameObject UI_Image_Lose;

    // player - bullet mechanics
    public GameObject DPlayer;
    public GameObject bulletD;


    bool runOnce = false;


    void Start()
    {

        // Text UI Smash Bros
        anim_text = text_smash_bros.GetComponent<Animator>();
        smash_bros_UI = text_smash_bros.GetComponent<Text>();
        text_smash_bros.gameObject.SetActive(false);

        // Restart
        anim_Restart = UI_Image_Restart.GetComponent<Animator>();
        anim_Restart.Play("Restart");

        // Lose
        anim_Lose = UI_Image_Lose.GetComponent<Animator>();
        UI_Image_Lose.gameObject.SetActive(false);

        Time.timeScale = 1;
        // StartCoroutine(StartScene());

        // Pone los lanza tomates en off cuando inicial nivel

        lanzador_balas.gameObject.SetActive(false);

        runOnce = false;

        

    }


    void Update()
    {
        

        if (!DPlayer.activeSelf && !runOnce)
        {
            StartCoroutine(ResetSCene());

            runOnce = true;
        }

        StartScene_UI();



    }




IEnumerator ResetSCene()
    {
        yield return new WaitForSeconds(2.5f);

        anim_Lose.gameObject.SetActive(true);
        anim_Lose.Play("Lose");
        
        yield return new WaitForSeconds(4);
        

        SceneManager.LoadScene("PracticaVectores");
    }


   // reviza si la animacion incial (Restart) se termió para poder ocultar el objeto de la animacion
   // e iniciar la animación de comienzo.

    public void StartScene_UI()
    {
        if (anim_Restart.GetCurrentAnimatorStateInfo(0).length < anim_Restart.GetCurrentAnimatorStateInfo(0).normalizedTime)
        {
            UI_Image_Restart.gameObject.SetActive(false);
            StartCoroutine(Start_Smash_Bros_UI());
        }

    }

    /* bool isAnimationStatePlaying(Animator anim_Restart, int animLayer, string stateName)
    {
        if (anim_Restart.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
                anim_Restart.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

    */


   IEnumerator Start_Smash_Bros_UI()
    {
        text_smash_bros.gameObject.SetActive(true);

        smash_bros_UI.text = "GET READY";
        anim_text.Play("Start_anim_GetReady");

        yield return new WaitForSeconds(anim_text.GetCurrentAnimatorStateInfo(0).length);

        smash_bros_UI.text = "3";
        anim_text.Play("Start_anim_3");

        yield return new WaitForSeconds(anim_text.GetCurrentAnimatorStateInfo(0).length);

        smash_bros_UI.text = "2";
        anim_text.Play("Start_anim_2");

        yield return new WaitForSeconds(anim_text.GetCurrentAnimatorStateInfo(0).length);

        smash_bros_UI.text = "1";
        anim_text.Play("Start_anim_1");

        yield return new WaitForSeconds(anim_text.GetCurrentAnimatorStateInfo(0).length);

        smash_bros_UI.text = "GO!";
        anim_text.Play("Start_anim_go");

        yield return new WaitForSeconds(anim_text.GetCurrentAnimatorStateInfo(0).length);

        
            lanzador_balas.gameObject.SetActive(true);
            text_smash_bros.gameObject.SetActive(false);
        

    }
    


}
