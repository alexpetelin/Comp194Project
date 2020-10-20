using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    bool isColliding = false;
    bool createBlock = false; 
    Vector3 handPos;
    void OnTriggerEnter(Collider other){
        if (other.transform.tag == "Hands"){
            isColliding = true; 
            Debug.Log("1");
            createBlock = false;
        }
    }
    
    // void OnTriggerExit(Collider other){
    //     if (other.transform.tag == "Hands"){
    //         isColliding = false;
    //         createBlock = false; 
    //         Debug.Log("3");
    //     }
    // }

    void OnTriggerStay(Collider other){
        if (other.transform.tag == "Hands"){
            handPos = other.transform.position;
            Debug.Log("2");
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding == true && createBlock == false /*&& Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2*/){
            createBlock = true; 
            Instantiate(blockPrefab, handPos, Quaternion.identity);
            Debug.Log("4");
        }
    }
    
}
