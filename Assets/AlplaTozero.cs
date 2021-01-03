using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AlplaTozero : MonoBehaviour {
    public float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Text>().color.a > 0)
        {
            GetComponent<Text>().color = new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, Mathf.Lerp(GetComponent<Text>().color.a, 0f, time));
        }
	}
}
