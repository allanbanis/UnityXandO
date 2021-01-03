using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreenCanvas : MonoBehaviour {
    public Button gameModeBtn, startBtn, OpponentBtn;
    string[] opponentsOptions= new string[2]{"vsPlayer","vsComputer"};
    string[] modeOption = new string[1] { "Time Attack" };
    int currOpponent = 0;

	// Use this for initialization
	void Start () {
        gameModeBtn.onClick.AddListener(gameModeChange);
        OpponentBtn.onClick.AddListener(OpponentChange);
        startBtn.onClick.AddListener(onStart);
	}
    void gameModeChange(){
        
    }
    void OpponentChange(){
        currOpponent++;
        if(currOpponent>opponentsOptions.Length-1){
            currOpponent = 0;
        }
        OpponentBtn.GetComponentInChildren<Text>().text = "Opponent:" + opponentsOptions[currOpponent];
    }
    void onStart(){
        SceneManager.LoadScene(1);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
