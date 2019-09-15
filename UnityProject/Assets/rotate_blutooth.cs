using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class rotate_bluetooth : MonoBehaviour
{

    public float szybkosc_obrotu_y = 15;
    float szybkosc_obr_y = 0;
    public float szybkosc_obrotu_x = 15;
    public GameObject action_button;
    float szybkosc_obr_x = 0;
    bool obrot = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            obrot = false;
        }
        if (Input.GetKey("a"))
        {
            obrot = true;
        }
        if (obrot)
        {
            //transform.Rotate(0, Time.deltaTime * szybkosc_obrotu_y, 0);
            //transform.Rotate(Time.deltaTime * szybkosc_obrotu_x, 0, 0);
            //if(true)
            //transform.Rotate(0, Time.deltaTime * Input.GetAxis("Joy3")* 150, 0);
            // transform.Rotate(Time.deltaTime * szybkosc_obrotu_x, 0, 0);
        }
        transform.Rotate(0, Time.deltaTime * Input.GetAxis("Joy3") * 15, 0);
    }

    public void ChanggeHRotationSpeed(float speed)
    {
        szybkosc_obrotu_y = speed;
    }

    public void ChanggeVRotationSpeed(float speed)
    {

        szybkosc_obrotu_x = speed;
    }

    public void StartStopRotation()
    {
        Text action_button_txt = action_button.GetComponent<Text>();

        if (obrot)
        {
            obrot = false;
            action_button_txt.text = "Rotate";
        }
        else
        {
            obrot = true;
            action_button_txt.text = "Hold";
        }
    }
}
