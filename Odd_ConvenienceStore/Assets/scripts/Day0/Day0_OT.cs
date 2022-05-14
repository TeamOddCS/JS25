using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day0_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day0.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day0_C.isChoice == true)
        {
            Day0.isDialogue = false;
        }
        else
        {
            Day0.isDialogue = true;
        }
    }
}
