using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movementscript : MonoBehaviour
{

    [Range(1,10)]
    public float speed;
    [Range(1,10)]
    public float rotateSpeed;
    public Transform[] target;
    private int current;
    private Quaternion neededRotation;

    private void Update ()
    {

        neededRotation = Quaternion.LookRotation(target[current].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, neededRotation, Time.deltaTime * rotateSpeed);


        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
          //  current = (current + 1) % target.Length;
            //Debug.Log(current);
        //}
    }
}
