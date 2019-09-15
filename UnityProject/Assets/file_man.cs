using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class file_man : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void filee()
    {
        string path;
        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                path = currentActivity.Call<AndroidJavaObject>("getFilesDir").Call<string>("getCanonicalPath");
            }
        }
    }
}
