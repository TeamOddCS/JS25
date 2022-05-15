using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Day4_F : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip ring;
    public AudioClip touchclip;



    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        Nextdialogue();
    }
    public void Nextdialogue()//��ȭ���� �ѱ�� �Լ�
    {
        
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = data[count]["Name"].ToString();
        data[count]["Script"] = data[count]["Script"].ToString().Replace("#", ",");
        data[count]["Script"] = data[count]["Script"].ToString().Replace("  ", "\n");
        txt_dialogue.text = data[count]["Script"].ToString();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }
        count++;
        Debug.Log(count);
    }
    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }

    private void day4_f_JD()
    {
        if (count < data.Count)
        {
            Nextdialogue();
            if (count == 18)
            {
                count += 7;
            }
            if (count == 26)
            {
                count += 13;
            }
            if (count == 41)
            {
                fade.Fade();
                Hidedialogue();
                SceneManager.LoadScene("Day5-1");
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
            SceneManager.LoadScene("Day5-1");
        }
    }
    private void Start()
    {
        data = CSVReader.Read("Day4-F");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day4_f_JD();
            }
        }
        else
            Hidedialogue();
    }
}
