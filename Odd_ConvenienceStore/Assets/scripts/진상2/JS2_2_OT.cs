using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS2_2_OT : MonoBehaviour
{
    public GameObject option_page,js2_2;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang2_2.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS2_2_C.isChoice == true)
        {
            JinSang2_2.isDialogue = false;
        }
        else
        {
            js2_2.GetComponent<JinSang2_2>().Showdialogue();
        }
    }
}

