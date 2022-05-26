using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS8_3_OT : MonoBehaviour
{
    public GameObject option_page,js8_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang8_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS8_3_C.isChoice == true)
        {
            JinSang8_3.isDialogue = false;
        }
        else
        {
            js8_3.GetComponent<JinSang8_3>().Showdialogue();
            
        }
    }
}
