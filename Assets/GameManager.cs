using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] players;
    public int currentPlayer;
    public int[] score;
    GameObject[] blocks;
    public bool gameover = false;
    public GameObject appManager;
    public Text playerNoti;
    float time=2f;
    bool reducetime = false;
    float gmeovertmr = 2f;
   public Text timeText;
    // Use this for initialization
    void Start()
    {
        appManager = GameObject.Find("AppManager").gameObject;
        if(appManager.GetComponent<AppManager>().isinverted){

            playerNoti.text = "Player 2 begins \n tap to play";
        }else{

            playerNoti.text ="Player 1 begins \n tap to play";
        }
        Stack<GameObject> temp = new Stack<GameObject>();
        for (int i = 9; i > 0; i--)
        {
            temp.Push(GameObject.Find("" + i));
        }
        blocks = temp.ToArray();

        score = new int[players.Length];
        for (int i = 0; i < score.Length; i++)
        {
            score[i] = 0;
        }
       
    }
    public void Reset()
    {
        appManager.GetComponent<AppManager>().changeScore(score);
        appManager.GetComponent<AppManager>().changePlayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void changePlayer()
    {
        if (blocks[0].GetComponent<SpriteRenderer>().sprite == blocks[1].GetComponent<SpriteRenderer>().sprite && blocks[1].GetComponent<SpriteRenderer>().sprite == blocks[2].GetComponent<SpriteRenderer>().sprite
            && blocks[0].GetComponent<SpriteRenderer>().sprite != null
            && blocks[1].GetComponent<SpriteRenderer>().sprite != null
            && blocks[2].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer1");
            gameover = true;
            score[currentPlayer]++;
           // Reset();
            return;
        }
        if (blocks[3].GetComponent<SpriteRenderer>().sprite == blocks[4].GetComponent<SpriteRenderer>().sprite && blocks[4].GetComponent<SpriteRenderer>().sprite == blocks[5].GetComponent<SpriteRenderer>().sprite
            && blocks[3].GetComponent<SpriteRenderer>().sprite != null
            && blocks[4].GetComponent<SpriteRenderer>().sprite != null
            && blocks[5].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer2");
            gameover = true;
            score[currentPlayer]++;
           // Reset();
            return;
        }
        if (blocks[6].GetComponent<SpriteRenderer>().sprite == blocks[7].GetComponent<SpriteRenderer>().sprite && blocks[7].GetComponent<SpriteRenderer>().sprite == blocks[8].GetComponent<SpriteRenderer>().sprite
            && blocks[6].GetComponent<SpriteRenderer>().sprite != null
            && blocks[7].GetComponent<SpriteRenderer>().sprite != null
            && blocks[8].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer3");
            gameover = true;
            score[currentPlayer]++;
            //Reset();
            return;
        }
        if (blocks[0].GetComponent<SpriteRenderer>().sprite == blocks[3].GetComponent<SpriteRenderer>().sprite && blocks[3].GetComponent<SpriteRenderer>().sprite == blocks[6].GetComponent<SpriteRenderer>().sprite
            && blocks[0].GetComponent<SpriteRenderer>().sprite != null
            && blocks[3].GetComponent<SpriteRenderer>().sprite != null
            && blocks[6].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer4");
            gameover = true;
            score[currentPlayer]++;
            //Reset();
            return;
        }
        if (blocks[1].GetComponent<SpriteRenderer>().sprite == blocks[4].GetComponent<SpriteRenderer>().sprite && blocks[4].GetComponent<SpriteRenderer>().sprite == blocks[7].GetComponent<SpriteRenderer>().sprite
            && blocks[1].GetComponent<SpriteRenderer>().sprite != null
            && blocks[4].GetComponent<SpriteRenderer>().sprite != null
            && blocks[7].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer5");
            gameover = true;
            score[currentPlayer]++;
           // Reset();
            return;
        }
        if (blocks[2].GetComponent<SpriteRenderer>().sprite == blocks[5].GetComponent<SpriteRenderer>().sprite && blocks[5].GetComponent<SpriteRenderer>().sprite == blocks[8].GetComponent<SpriteRenderer>().sprite
            && blocks[2].GetComponent<SpriteRenderer>().sprite != null
            && blocks[5].GetComponent<SpriteRenderer>().sprite != null
            && blocks[8].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer6"); gameover = true;
            score[currentPlayer]++;
           // Reset();
            return;
        }
        if (blocks[0].GetComponent<SpriteRenderer>().sprite == blocks[4].GetComponent<SpriteRenderer>().sprite && blocks[4].GetComponent<SpriteRenderer>().sprite == blocks[8].GetComponent<SpriteRenderer>().sprite
            && blocks[0].GetComponent<SpriteRenderer>().sprite != null
            && blocks[4].GetComponent<SpriteRenderer>().sprite != null
            && blocks[8].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer7"); gameover = true;
            score[currentPlayer]++;
           // Reset();
            return;
        }
        if (blocks[2].GetComponent<SpriteRenderer>().sprite == blocks[4].GetComponent<SpriteRenderer>().sprite && blocks[4].GetComponent<SpriteRenderer>().sprite == blocks[6].GetComponent<SpriteRenderer>().sprite
            && blocks[2].GetComponent<SpriteRenderer>().sprite != null
            && blocks[4].GetComponent<SpriteRenderer>().sprite != null
            && blocks[6].GetComponent<SpriteRenderer>().sprite != null)
        {
            Debug.Log("GAmeoVer8"); gameover = true;
            score[currentPlayer]++;
          //  Reset();
            return;
        }
        bool chk = true;
        foreach (GameObject blck in blocks)
        {
            if (blck.GetComponent<SpriteRenderer>().sprite == null)
            {
                chk = false;
                break;
            }
        }
        if (chk)
        {
            Debug.Log("StaleMate");
            gameover = true;
            //Reset();
            return;
        }
        currentPlayer++;
        if (currentPlayer >= players.Length)
        {
            currentPlayer = 0;
        }

    }
	private void Update()
	{
        if(reducetime &&!gameover){

            time -= Time.deltaTime;
            if (time < 0){
                time = 0;
            }
            string tme = "" + time+"    ";

            timeText.text = tme.Substring(0,4);
            if(time<0.0000001){
                reducetime = false;
                gameover = true;
                changePlayer();
                score[currentPlayer]++;
               
            }
        }
        if(gameover){
            gmeovertmr -= Time.deltaTime;
            if(gmeovertmr<0){

                Reset();
            }

        }
	}
	public void resetTime() 
	{
        time = 1.5f;
        reducetime = true;
	}
}
