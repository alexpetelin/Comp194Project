using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public GameObject trashcanobject;

    void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "block"){
            Destroy(other.gameObject);
        } 
    }
  
}
