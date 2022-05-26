using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS4_3_OT : MonoBehaviour
{
    public GameObject option_page,js4_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang4_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS4_C.isChoice == true)
        {
            JinSang4_3.isDialogue = false;
        }
        else
        {
           js4_3.GetComponent<JinSang4_3>().Showdialogue();
        }
    }
}
