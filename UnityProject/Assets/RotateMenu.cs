using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google;

public class RotateMenu : MonoBehaviour {

    public Transform Player;
    public bool rotate = true;

    // Use this for initialization
    void Start () {
        Vector3 forward = new Vector3(0, 1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (rotate)
        {
            Vector3 temp = Player.transform.rotation.eulerAngles;
            temp.x = 30.0f;
            temp.z = 0.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
    }

    public void StopRotate()
    {
        if (rotate)
            rotate = false;
    }
    public void StartRotate()
    {
        if (!rotate)
            rotate = true;
    }
}
