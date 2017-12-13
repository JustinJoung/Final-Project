using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class death : MonoBehaviour {
    public float fallzone = 20f;
    public Transform playerpos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerpos.position.y < fallzone)
        {
            SceneManager.LoadScene("Game Over");
        }
	}
}
