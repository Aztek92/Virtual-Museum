using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setText : MonoBehaviour {

    public GameObject test0;
    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public Material lejek_mat;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTexture()
    {
        Renderer rendtest0 = test0.GetComponent<MeshRenderer>();
        rendtest0.material = lejek_mat;
        Renderer rendtest1 = test1.GetComponent<MeshRenderer>();
        rendtest1.material = lejek_mat;
        Renderer rendtest2 = test2.GetComponent<MeshRenderer>();
        rendtest2.material = lejek_mat;
        Renderer rendtest3 = test3.GetComponent<MeshRenderer>();
        rendtest3.material = lejek_mat;
    }
}
