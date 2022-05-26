using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS4_2_OT : MonoBehaviour
{
    public GameObject option_page,js4_2;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang4_2.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS4_C.isChoice == true)
        {
            JinSang4_2.isDialogue = false;
        }
        else
        {
            js4_2.GetComponent<JinSang4_2>().Showdialogue();
        }
    }
}
