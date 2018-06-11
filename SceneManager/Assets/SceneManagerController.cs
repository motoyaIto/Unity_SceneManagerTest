using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //現在のシーンの名前を取得する
        //Debug.Log(SceneManager.GetActiveScene().name);

        Debug.Log(SceneManager.sceneCount);

        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
