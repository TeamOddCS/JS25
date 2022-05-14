using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1_1_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day1_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day1_1_C.isChoice == true)
        {
            Day1_1.isDialogue = false;
        }
        else
        {
            Day1_1.isDialogue = true;
        }
    }
}
