using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    protected int startspeed = 1;
    //
    protected Rigidbody rb;

    void Awake(){
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Start(){
        rb.velocity = new Vector3(0,0,startspeed);
    }
}
