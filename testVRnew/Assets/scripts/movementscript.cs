using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movementscript : MonoBehaviour
{

    [SerializeField]
    [Range(6, 18)]
    private float speed;
    [SerializeField]
    [Range(0.1f, 10f)]
    private float rotateSpeed;

    [SerializeField]
    private List<Transform> target;
    private int current;

    private Quaternion neededRotation;

    

    private void Update ()
    {
        Movement();
    }

    /// <summary>
    /// Movement car
    /// </summary>
    private void Movement()
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
            current = (current + 1) % target.Count;
        }

        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        current = (current + 1) % target.Count;
        //        Debug.Log(current);
        //    }
    }
}
