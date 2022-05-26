using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day6_F_OT : MonoBehaviour
{
    public GameObject option_page,day6_f;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day6_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day6_F_C.isChoice == true)
        {
            Day6_F.isDialogue = false;
        }
        else
        {
            day6_f.GetComponent<Day6_F>().Showdialogue();
        }
    }
}
