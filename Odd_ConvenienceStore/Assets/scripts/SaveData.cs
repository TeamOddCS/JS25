using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static string Name = "test";
    public static string checkLevel = "난이도";
    public static int count; //지문 위치 표시

    public static string DataPath = "/Userdata.dat";

    public static bool DoChangeData = false;
    public static bool DoLoadData = false;
    public static bool RemakeDataInHub = false;
    public static bool Check_Loads_Files = false;

    public static int[] JinSangvisit = new int[9];
    public static int health = 3;
    public static string JSName = " ";
    public static int reGame;
    public static string reGameStart;
    public static int reGameChoice;

    public static int JinSang6Day1 = 0;

    public static string TempScene = " ";
    public static int TempCount = 0;

    // Start is called before the first frame update

    [Serializable]
    public class Players
    {
        public string name_; //닉네임
        public string level_; //난이도
        public int[] JinSangvisit_; //진상 방문 횟수
        public int JinSang6Day1_; //진상6 첫 방문에서의 선택
        public string TempScene_; //현재 다이얼로그 위치
        public int TempCount_;

        public int health_;
        public string JSName_;
        public int reGame_;
        public string reGameStart_;
        public int reGameChoice_;
    }

    public static void Saves()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + DataPath);

        Players data = new Players();

        //A->B
        data.name_ = Name;
        data.level_ = checkLevel;
        data.JinSangvisit_ = JinSangvisit;
        data.health_ = health;
        data.JSName_ = JSName;
        data.reGame_ = reGame;
        data.reGameStart_ = reGameStart;
        data.reGameChoice_ = reGameChoice;
        data.TempScene_ = TempScene;
        data.TempCount_ = TempCount;

        data.JinSang6Day1_ = JinSang6Day1;

        //B직렬화 & 파일 저장
        bf.Serialize(file, data);
        file.Close();
    }

    public static void Loads()
    {
        BinaryFormatter bf = new BinaryFormatter();

        try
        {
            FileStream file = File.Open(Application.persistentDataPath + DataPath, FileMode.Open);
            if (file != null && file.Length > 0)
            {
                Players data = (Players)bf.Deserialize(file);

                //B--->A
                Name = data.name_;
                checkLevel = data.level_;
                JinSangvisit = data.JinSangvisit_;
                JinSang6Day1 = data.JinSang6Day1_;
                health = data.health_;
                JSName = data.JSName_;
                reGame = data.reGame_;
                reGameStart = data.reGameStart_;
                reGameChoice = data.reGameChoice_;
                TempScene = data.TempScene_;
                TempCount = data.TempCount_;
            }
            Check_Loads_Files = true;
            file.Close();
        }catch{
            Check_Loads_Files = false;
        }
    }
  


    private void Awake()
    {
        if (DoChangeData == true)
        {
            Saves();

            DoChangeData = false;
        }

        if (DoLoadData == true)
        {
            Loads();

            if (RemakeDataInHub == true)
            {
                //데이터 remake하기
                RemakeDataInHub = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DoChangeData == true)
        {
            Saves();

            DoChangeData = false;
        }

        if (DoLoadData == true)
        {
            Loads();

            if (RemakeDataInHub == true)
            {

                CheckUserData.이름확인용.GetComponent<Text>().text = Name;
                CheckUserData.난이도확인용.GetComponent<Text>().text = checkLevel;

                RemakeDataInHub = false;
            }

            UnityEngine.Debug.Log(Name);
            UnityEngine.Debug.Log(checkLevel);

            DoLoadData = false;
        }
    }
}
