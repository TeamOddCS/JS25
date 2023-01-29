using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundManager instance;
    public AudioMixer mixer;
    public AudioSource bgm;
    public AudioClip[] bgmlist;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
   
    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (SceneManager.GetActiveScene().name == "Title")
            BGMplay(bgmlist[0]);
        else
            BGMplay(bgmlist[1]);
    }
    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups("SFX")[0];
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(go, clip.length); 
    }

    public void BGMplay(AudioClip clip)
    {
        bgm.outputAudioMixerGroup = mixer.FindMatchingGroups("BGM")[0];
        bgm.clip = clip;
        bgm.loop = true;
        bgm.volume = 0.1f;
        bgm.Play();

    }

    public void SFXVolume(float val)
    {
        mixer.SetFloat("BGMvolume", Mathf.Log10(val) * 20);
    }
    public void MusicToggle(bool musicOn)
    {
        if (musicOn)
        {
            AudioListener.volume = 1;

        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
