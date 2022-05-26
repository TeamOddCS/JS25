using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1_F_OT : MonoBehaviour
{
    public GameObject option_page,day1_f;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day1_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day1_F_C.isChoice == true)
        {
            Day1_F.isDialogue = false;
        }
        else
        {
            day1_f.GetComponent<Day1_F>().Showdialogue();
        }
    }
}
