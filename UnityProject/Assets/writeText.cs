using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writeText : MonoBehaviour {

    public GameObject text;
    public GameObject action_button;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void set()
    {
        Text txt = text.GetComponent<Text>();
        if (txt.text.Length == 0)
        {
            string path;
            using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (AndroidJavaObject currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity"))
                {
                    path = currentActivity.Call<AndroidJavaObject>("getFilesDir").Call<string>("getCanonicalPath");
                }
            }
                    txt.fontSize = 10;
            //txt.text = "Dzban (kruża) – naczynie gospodarcze o szerokim zastosowaniu, zwykle służące do przenoszenia (przechowywania) płynów lub drobnoziarnistych materiałów sypkich. Typowy dzban składa się przysadzistego, pękatego brzuśca, szerokiego wylewu oraz pionowego uchwytu(imadła). Proste dzbany domowe nie mają stopki ani przykrycia; pokrywki występują w dzbanach służących do transportu(jak np.na obrazie Francisca Goi).Mniejsze dzbany(dzbanki, dzbanuszki - mleczniki) bywają częścią zastawy stołowej. Na ogół ceramiczne, mogą też być wykonane z innych materiałów – szkła albo metalu.";
            txt.text = path;
            Text action_button_txt = action_button.GetComponent<Text>();
            //action_button_txt.text = "Hide text";
        }
        else
        {
            if (text.active)
            {
                Text action_button_txt = action_button.GetComponent<Text>();
                //action_button_txt.text = "Show text";
                text.SetActive(false);
            }
            else
            {
                Text action_button_txt = action_button.GetComponent<Text>();
                //action_button_txt.text = "Hide text";
                text.SetActive(true);
            }
        }
    }
}
