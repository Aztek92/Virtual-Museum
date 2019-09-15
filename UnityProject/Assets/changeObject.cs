using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class changeObject : MonoBehaviour
{
    private bool changeState;
    public List<GameObject> selected = new List<GameObject>();      //lista modeli
    public Dropdown dropdown;
    public int i = 0;
    //public GameObject modele;
    public GameObject text;

    List<String> opis = new List<String>();

    // Use this for initialization
    void Start()
    {
        changeState = true;
        selected[i].SetActive(true);
        opis.Add("Chochla – narzędzie do nakładania posiłków (sztuciec). Duża łyżka przystosowana do głębokich naczyń. Wykonana najczęściej z metalu lub tworzyw sztucznych. Chochlą nalewa się zazwyczaj zupę lub inne ciecze. Typowa chochla ma długi uchwyt zakończony małą, głęboką miską, często ustawioną pod takim kątem, by ułatwić podnoszenie cieczy.");
        opis.Add("Dzban (kruża) – naczynie gospodarcze o szerokim zastosowaniu, zwykle służące do przenoszenia (przechowywania) płynów lub drobnoziarnistych materiałów sypkich. Typowy dzban składa się przysadzistego, pękatego brzuśca, szerokiego wylewu oraz pionowego uchwytu(imadła).");
        opis.Add("Czaszka (łac. cranium) – struktura kostna lub chrzęstna, która służy jako szkielet głowy. Stanowi naturalną osłonę mózgu i innych narządów znajdujących się w głowie. Wzrost czaszki człowieka trwa nie tylko podczas życia płodowego, ale praktycznie aż do osiągnięcia wieku dorosłego.");
        opis.Add("Ossuarium (także ossarium, z łac. od ossuarius – kostny, ossua – kości, kościec, l. mn. od os, ossis – kość) – naczynie lub inny pojemnik służący do przechowywania kości albo prochów zmarłego, którego poddano kremacji.");
        opis.Add("Lejek (łac. infundibulum) – anatomiczna część międzymózgowia, proksymalnie będąca przedłużeniem guza popielatego, natomiast dystalnie przechodząca w tylny płat przysadki. Światło lejka łączy się z komorą trzecią – jest to tzw. zachyłek lejka.");
        opis.Add("Kamienna_Tablica.exe");
        //Text txt = text.GetComponent<Text>();
        //txt.text = opis[i];
        Text text;
        int lenght = 0;
        foreach (string file in Directory.GetFiles("C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/", "*.prefab"))
        {
            Debug.Log(file);
            string str = "C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/";
            //file = file.Substring(10, 10);
            lenght = file.Length - str.Length;
            dropdown.options.Add(new Dropdown.OptionData() { text = file.Substring(138, lenght) });
        }
        dropdown.value = 1;
        dropdown.value = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addObj()
    {
        // Vector3 poz = 
        // modele.transform.SetPositionAndRotation(new Vector3(1, 1, 1), new Quaternion(0, 0, 0, 0));
        //for (int i = 0; i < 5; i++)
        //{
        //modele.transform.SetPositionAndRotation(new Vector3(1, i, i), new Quaternion(0, 0, 0, 0));
        //Instantiate(modele);
        // }
        //modele.transform.SetPositionAndRotation(new Vector3(1, 1, 1), new Quaternion(0, 0, 0, 0));
        //GameObject t = (GameObject)AssetDatabase.LoadAssetAtPath("C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/M2-02_dzbanek_z_nozkami_simple80K.prefab", typeof(GameObject));
        //Instantiate(t);
        //GameObject t = (GameObject)AssetDatabase.LoadAssetAtPath("C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/M2-02_dzbanek_z_nozkami_simple80K.prefab", typeof(GameObject));
        //GameObject t = (GameObject)AssetDatabase.CreateAsset( , "C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/M2-02_dzbanek_z_nozkami_simple80K.prefab");

        //Instantiate(t);
        //GameObject instance = Instantiate(Resources.Load("M2-02_dzbanek_z_nozkami_simple80K.prefab", typeof(GameObject))) as GameObject;
        //UnityEngine.Object pPrefab = Resources.Load("C:/Users/Ryszard/Rzeczy/Unity,Gry/Projekty/Nowe ćwiczenia/New Unity Project 2/vr_app/Assets/GoogleVR/Models/modele_inz/modele_wyskalowane/M2-02_dzbanek_z_nozkami_simple80K"); // note: not .prefab!
        //GameObject pNewObject = (GameObject)GameObject.Instantiate(pPrefab, Vector3.zero, Quaternion.identity);

    }

    public void nextObj()//wyświetla następny objiekt z listy
    {
        Text txt = text.GetComponent<Text>();
        if (changeState)
        {
            if (i < selected.Count-1)
                i++;
            else
                i = 0;
            changeState = false;
            if (i == 0)
            {
                selected[i].SetActive(true);
                selected[selected.Count - 1].SetActive(false);
                txt.text = opis[i];
            }
            else
            {
                selected[i - 1].SetActive(false);
                selected[i].SetActive(true);
                txt.text = opis[i];
            }
            changeState = true;
        }
        changeState = true;
    }

    public void prevObj()// wyświetla poprzedni objekt z listy
    {
        Text txt = text.GetComponent<Text>();
        if (changeState)
        {
            if (i > 0)
                i--;
            else
                i = selected.Count - 1;
            changeState = false;
            if (i == selected.Count - 1)
            {
                selected[0].SetActive(false);
                selected[selected.Count - 1].SetActive(true);
                txt.text = opis[i];
            }
            else
            {
                selected[i + 1].SetActive(false);
                selected[i].SetActive(true);
                txt.text = opis[i];
            }
            changeState = true;
        }
        changeState = true;
    }
}
