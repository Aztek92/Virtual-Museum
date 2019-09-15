using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour {

    TextToSpeech tts;
    public Text description;
    //public Text description;
    void Start()
    {
        tts = GetComponent<TextToSpeech>();
    }
    public void Speak()
    {
        tts.Speak(description.text, (string msg) =>
        {
            tts.ShowToast(msg);
        });
    }
}
