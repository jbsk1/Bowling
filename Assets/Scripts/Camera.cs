using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject pl;

    void Awake(){
        pl = GameObject.Find("Ball");
    }

    void Update()
    {
        var p = pl.transform.position;
        if(p.z<=22){
        gameObject.transform.position = new Vector3(0,(float)1.5,p.z-2);
        }
    }
}
