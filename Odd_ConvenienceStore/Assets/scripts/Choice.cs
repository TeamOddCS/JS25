using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
  
}

public class Choice : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    
    private int count = 1;
    [SerializeField] private choice[] choice;
    public void ShowChoice()//
    {       
        ChoiceOn();
        count = 0;
        
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

    }
    public void NextChoice(int cnt)
    {          
        count++;
        Dialouge.count += cnt;
        ChoiceOff();
    }
    public void ChoiceOn()
    {
        Dialouge.isDialouge = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Dialouge.isDialouge = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        if (Dialouge.count == 8)
        {
            ShowChoice();
        }
    }

    private void Start()
    {
        ChoiceOff();
       
    }
    private void Update()
    {       
            CallChoice();   
    }
}
