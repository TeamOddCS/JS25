using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3_1_OT : MonoBehaviour
{
    public GameObject option_page,day3_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day3_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day3_1_C.isChoice == true)
        {
            Day3_1.isDialogue = false;
        }
        else
        {
            day3_1.GetComponent<Day3_1>().Showdialogue();
        }
    }
}
