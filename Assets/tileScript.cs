using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = null;
	}

	private void OnMouseDown()
	{
        if(Camera.main.GetComponent<GameManager>().gameover){
            return;
        }
        if(GetComponent<SpriteRenderer>().sprite==null){
            GetComponent<SpriteRenderer>().sprite = Camera.main.GetComponent<GameManager>().players[Camera.main.GetComponent<GameManager>().currentPlayer];
            Camera.main.GetComponent<GameManager>().changePlayer();
            Camera.main.GetComponent<GameManager>().resetTime();
        }

	}
}
