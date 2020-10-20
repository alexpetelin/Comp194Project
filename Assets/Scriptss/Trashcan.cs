using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public GameObject trashcanobject;

    void OnCollisionEnter(Collision other) {
        
            Destroy(other.gameObject);
        
    }
  
}
