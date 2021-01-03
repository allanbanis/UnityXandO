using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("AppManager").gameObject.GetComponent<AppManager>().clearplayers();
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
	}
}
