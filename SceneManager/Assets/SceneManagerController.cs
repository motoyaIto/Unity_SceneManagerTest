using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //現在のシーンの名前を取得する
        //Debug.Log(SceneManager.GetActiveScene().name);

        //シーンをロードする
        SceneManager.LoadScene("Scene2");

        //読み込まれてるシーン数を取得する
        Debug.Log(SceneManager.sceneCount);

        //読み込まれてるシーンの名前を取得
        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            Debug.Log(SceneManager.GetSceneAt(i).name);
        }

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
