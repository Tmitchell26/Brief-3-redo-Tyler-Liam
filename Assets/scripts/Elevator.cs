using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour{

    public GameObject moveplatform;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Character")
        {
            other.transform.parent = this.transform;
            moveplatform.transform.position -= moveplatform.transform.up * (Time.deltaTime * 2);
        } 
    }
}
