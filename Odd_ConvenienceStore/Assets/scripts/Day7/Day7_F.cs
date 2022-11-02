using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day7_F : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü

    private string inputText;
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip ring;
    public static int facenum = 0;
    Camera Camera;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        if(count==0)
            Nextdialogue();
    }
    public void Nextdialogue()//��ȭ���� �ѱ�� �Լ�
    {
        Debug.Log(count);
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = data[count]["Name"].ToString();
        data[count]["Script"] = data[count]["Script"].ToString().Replace("#", ",");
        data[count]["Script"] = data[count]["Script"].ToString().Replace("  ", "\n");
        //txt_dialogue.text = data[count]["Script"].ToString();
        inputText = data[count]["Script"].ToString();
        StartCoroutine("typingText");
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }    
        count++;
        Facechange();
    }
    public void Facechange()
    {
        if (data[count]["Face"].ToString().Equals("0"))
        {
            facenum = 1;
        }

    }

    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day7_F_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 23)
            {
                count += 32 - 23;
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
        }
    }

    IEnumerator typingText()
    {
        char nowChar;
        string showText = " ";
        for (int i = 0; i < inputText.Length; i++)
        {
            nowChar = inputText[i];
            showText = inputText.Substring(0, i);
            txt_dialogue.text = showText + nowChar.ToString();
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void Start()
    {
        data = CSVReader.Read("Day7-F");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.ScreenToWorldPoint(mousePos);
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0)
                    day7_F_JD();
            }
        }
        else
            Hidedialogue();
    }
}
