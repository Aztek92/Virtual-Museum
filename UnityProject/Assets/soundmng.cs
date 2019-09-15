using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class soundmng : MonoBehaviour
{
    public GameObject action_button;
    public Sprite mute_spr;
    public Sprite unmute_spr;
    AudioSource m_MyAudioSource;
    // Use this for initialization
    void Start()
    {
        //m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void mute()
    {
        Image action_button_img = action_button.GetComponent<Image>();
        m_MyAudioSource = GetComponent<AudioSource>();
        if (m_MyAudioSource.mute)
        {
            m_MyAudioSource.mute = false;
            action_button_img.sprite = unmute_spr;
        }
        else
        {
            m_MyAudioSource.mute = true;
            action_button_img.sprite = mute_spr;
        }
    }
}
