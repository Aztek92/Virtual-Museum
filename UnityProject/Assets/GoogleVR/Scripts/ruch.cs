using System.Collections;
using UnityEngine;


public class ruch : MonoBehaviour
{
    public Transform MainCamera;
    public CharacterController cc;
    public float szybkoscGracza;
    float szybkoscGracza_temp;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)||Input.GetButton("Fire1"))
        {
            move_forward();
        }
        if (Input.GetMouseButton(1) || Input.GetButton("Fire2"))
        {
            move_backward();
        }
    }

    public void move_forward()
    {
        Vector3 forward = MainCamera.TransformDirection(Vector3.forward);
        cc.SimpleMove(forward * szybkoscGracza);
    }
    public void move_backward()
    {
        Vector3 forward = MainCamera.TransformDirection(Vector3.forward);
        cc.SimpleMove(forward * szybkoscGracza*-1);
    }

    public void Stop_move()
    {
        szybkoscGracza_temp = szybkoscGracza;
        szybkoscGracza = 0;
    }

    public void Start_move()
    {
        szybkoscGracza = szybkoscGracza_temp;
    }
}