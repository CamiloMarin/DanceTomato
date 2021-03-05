using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Scene : MonoBehaviour
{

    public Animator anim_Restart;
    public Animator anim_Lose;
    public GameObject DPlayer;
    public GameObject bulletD;
    public GameObject UI_Image_Restart;
    public GameObject UI_Image_Lose;
    
    bool runOnce = false;
   

    void Start()
    {
        // Restart
        anim_Restart= UI_Image_Restart.GetComponent<Animator>();
        anim_Restart.Play("Restart");

        // Lose
        anim_Lose = UI_Image_Lose.GetComponent<Animator>();
        UI_Image_Lose.gameObject.SetActive(false);

        Time.timeScale = 1;
        StartCoroutine(StartScene());
        
        runOnce = false;

    }

   
    void Update()
    {


        if (!DPlayer.activeSelf && !runOnce)
        {
            StartCoroutine(ResetSCene());
            
            runOnce = true;
        }
        Debug.Log(runOnce);

        

        
        
    }

    IEnumerator ResetSCene()
    {
        yield return new WaitForSeconds(4);
        anim_Lose.gameObject.SetActive(true);
        anim_Lose.Play("Lose");
        
        yield return new WaitForSeconds(3);
        

        SceneManager.LoadScene("PracticaVectores");
    }


    IEnumerator StartScene()
    {

        yield return new WaitForSeconds(3);

        UI_Image_Restart.gameObject.SetActive(false);

    }

}
