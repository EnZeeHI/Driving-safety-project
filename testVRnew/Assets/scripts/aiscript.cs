using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiscript : MonoBehaviour {

    public trafficlightscript trafficLight;
    public movementscript movescript;
    public Collider carCollide;
    public Transform spawn;


	// Use this for initialization
	void Start () {
        movescript.speed = 15;
	}
	
	// Update is called once per frame
	void Update () {
		if(movescript.current == 1 && trafficLight.i != 1)
        {
            movescript.speed = 0;
        } else if(movescript.current == 1 && trafficLight.i == 1)
        {
            movescript.speed = 15;
        }
	}
}
