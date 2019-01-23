using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiscript : MonoBehaviour
{

    public movementscript movescript;
    public trafficlightscript trafficScript;
    public Transform spawnLoc;
    [SerializeField]
    private int lightNumber;
    [SerializeField]
    private int lightLoc;
    [SerializeField]
    private float standardSpeed;


    // Use this for initialization
    void Start()
    {
        movescript.speed = standardSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (movescript.current == lightLoc && trafficScript.i != lightNumber)
        {
            movescript.speed = 0;
        }
        else if (movescript.current == lightLoc && trafficScript.i == lightNumber)
        {
            movescript.speed = standardSpeed;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (movescript.current != lightLoc)
        {
            movescript.speed = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (movescript.current != lightLoc)
        {
            movescript.speed = standardSpeed;
        }
    }
}