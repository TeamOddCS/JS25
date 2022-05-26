using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS8_1_OT : MonoBehaviour
{
    public GameObject option_page,js8_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang8_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS8_1_C.isChoice == true)
        {
            JinSang8_1.isDialogue = false;
        }
        else
        {
            js8_1.GetComponent<JinSang8_1>().Showdialogue();
        }
    }
}
