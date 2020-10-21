using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    bool isColliding = false;
    bool createBlock = false;
    public GameObject hands; 
    void OnTriggerEnter(Collider other){
        if (other.transform.tag == "Hands"){
            GameObject hands = other.gameObject; 
            isColliding = true;
            createBlock = false;
        }
    }
    
    void OnTriggerExit(Collider other){
        if (other.transform.tag == "Hands"){
            isColliding = false;
            createBlock = false; 
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isColliding == true && createBlock == false){
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") > 0.2 || Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2){
                createBlock = true; 
                Instantiate(blockPrefab, hands.transform.position, Quaternion.identity);
            }
        }
    }
    
}
