using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1_3_OT : MonoBehaviour
{
    public GameObject option_page,day1_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day1_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day1_3_C.isChoice == true)
        {
            Day1_3.isDialogue = false;
        }
        else
        {
            day1_3.GetComponent<Day1_3>().Showdialogue();
        }
    }
}
