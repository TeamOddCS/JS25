using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3_F_OT : MonoBehaviour
{
    public GameObject option_page,day3_f;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day3_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day3_F_C.isChoice == true)
        {
            Day3_F.isDialogue = false;
        }
        else
        {
           day3_f.GetComponent<Day3_F>().Showdialogue();
        }
    }
}
