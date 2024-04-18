using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    [SerializeField] Transform target;
    Shadow_Comportamiento velocity;
    Rigidbody shadow;

    private void Start()
    {
        shadow = GetComponent<Rigidbody>();
        velocity = GetComponent<Shadow_Comportamiento>();
    }

    private void Update()
    {
        this.transform.LookAt(target);
        shadow.MovePosition(Vector3.MoveTowards(shadow.position, target.position, velocity.velocidad));       
    }
}
