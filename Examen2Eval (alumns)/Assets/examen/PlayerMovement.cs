using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int jumpcount = 0, mamaMiacount;
    private TMP_Text jumpText, mamaMiaText;
    private Animator animator;
    void Update()
    {
        if(x != 0)
        {
            animator.SetBool("iswalking", true);

        }
        else
        {
            animator.SetBool("iswalking", false);
        }
    }
    void Start()
    {
        jumpText = UImanager.GetInstance().GetUIElemet("jumpstext").GetComponent<TMP_Text>();
        mamaMiaText = UImanager.GetInstance().GetUIElemet("stepstext").GetComponent<TMP_Text>();

    }
    public void IncrementMamaMia()
    {
        mamaMiacount++;
        mamaMiaText.text = "mama mia" + mamaMiacount;
    }
    //parte del salto
    jumpcount ++;
    jumpText.text = "Numero de saltos:" + jumpcount;
}
