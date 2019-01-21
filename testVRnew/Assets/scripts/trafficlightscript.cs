using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlightscript : MonoBehaviour {

    [SerializeField]
    private Renderer green1;
    [SerializeField]
    private Renderer red1;
    [SerializeField]
    private Renderer green2;
    [SerializeField]
    private Renderer red2;
    [SerializeField]
    private Renderer green3;
    [SerializeField]
    private Renderer red3;
    [SerializeField]
    private Renderer green4;
    [SerializeField]
    private Renderer red4;
    public float timestart = 5.0f;
    private float timer;
    public int i = 1;
    public Material green;
    public Material red;
    public Material off;

    // Use this for initialization
    void Start () {
        green1.material = green;
        red2.material = red;
        red3.material = red;
        red4.material = red;
        timer = timestart;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (i == 1 && timer <= 0)
        {
            green1.material = off;
            red1.material = red;
            red2.material = off;
            green2.material = green;
            timer = timestart;
            i++;
        }
        else if(i == 2 && timer <= 0)
        {
            red2.material = red;
            green2.material = off;
            red3.material = off;
            green3.material = green;
            timer = timestart;
            i++;
        }
        else if(i == 3 && timer <= 0)
        {
            red3.material = red;
            green3.material = off;
            red4.material = off;
            green4.material = green;
            timer = timestart;
            i++;
        }
        else if(i == 4 && timer <= 0)
        {
            red4.material = red;
            green4.material = off;
            red1.material = off;
            green1.material = green;
            timer = timestart;
            i = 1;
        }
	}
}
