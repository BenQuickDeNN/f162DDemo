using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileShot : MonoBehaviour {
    public int damage = 1;
    public bool isClone = false;
	// Use this for initialization
	void Start () {
        if(isClone)Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
