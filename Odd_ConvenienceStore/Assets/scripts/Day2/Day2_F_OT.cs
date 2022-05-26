using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2_F_OT : MonoBehaviour
{
    public GameObject option_page,day2_f;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day2_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day2_F_C.isChoice == true)
        {
            Day2_F.isDialogue = false;
        }
        else
        {
            day2_f.GetComponent<Day2_F>().Showdialogue();
        }
    }
}
