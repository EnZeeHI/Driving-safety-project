using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test_Movement : MonoBehaviour
{
    private float speed = 10f;

    private Rigidbody rb;

    [SerializeField]
    private List<Target> targetList;
    private int currentTarget = 0;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position != targetList[currentTarget].transform.position)
        {
            Vector3 direction = new Vector3(transform.position.x + targetList[currentTarget].transform.position.x, transform.position.y + targetList[currentTarget].transform.position.y, transform.position.z + targetList[currentTarget].transform.position.z);
            rb.velocity = direction * (speed * Time.deltaTime);
        }
        else
        {
            currentTarget = (currentTarget + 1) % targetList.Count;
        }

    }








}