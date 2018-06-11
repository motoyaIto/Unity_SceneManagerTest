using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {

    int a = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a+=10;
        Vector3 pos = transform.position;
        pos.x += Mathf.Sin(a);

	}
}
