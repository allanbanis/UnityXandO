using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour {
    public static AppManager instance = null;
    public int player1, player2;
    public bool isinverted = false;
   
    void Awake()
    {

        // check if there is already a gamemanager in the scene
        if (instance == null)
        {
            instance = this;


        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        player1 = 0;
        player2 = 0;
	}
    public void changePlayer(){
        isinverted = !isinverted;
    }
    public void clearplayers(){
        isinverted = false;
        player2 = 0;
        player1 = 0;
    }
    public void changeScore(int[] score){
        Debug.Log(isinverted + "::" + score[0] + "::" + score[1]);
        if(isinverted){
            player2 += score[0];
            player1 += score[1];
        }else{
            
            player1 += score[0];
            player2 += score[1];
        }
    }
	
}
