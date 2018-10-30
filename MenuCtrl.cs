using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.anyKey)
        {
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene("InGameScene", LoadSceneMode.Single);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
