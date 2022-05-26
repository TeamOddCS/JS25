using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5_1_OT : MonoBehaviour
{
    public GameObject option_page,day5_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day5_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day5_1_C.isChoice == true)
        {
            Day5_1.isDialogue = false;
        }
        else
        {
            day5_1.GetComponent<Day5_1>().Showdialogue();
        }
    }
}
