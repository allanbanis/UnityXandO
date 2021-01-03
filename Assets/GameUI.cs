using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
    public Text player1score, player2score, player1symbol, player2symbol;
    GameObject Appmanager;
	// Use this for initialization
	void Start () {
        Appmanager = GameObject.Find("AppManager").gameObject;
        player1score.text = "" + Appmanager.GetComponent<AppManager>().player1;
            player2score.text = "" + Appmanager.GetComponent<AppManager>().player2;
        if(Appmanager.GetComponent<AppManager>().isinverted){
            player1symbol.text = "Symbol: O";
            player2symbol.text = "Symbol: X";

        }else{
            player1symbol.text = "Symbol: X";
            player2symbol.text = "Symbol: O";
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
