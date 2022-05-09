using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionTrigger : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day3_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        Day3_3.isDialogue = true;
    }

}
