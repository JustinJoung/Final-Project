using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageTurner : MonoBehaviour {
    public float j;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void onMouseDown() 
    {
        this.transform.parent.GetComponent<CanvasGroup>().alpha = 0;
    }
}
