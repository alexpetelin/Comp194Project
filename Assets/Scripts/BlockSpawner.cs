using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject rectBlockPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        if(other.transform.tag == "Hands")
        {
            Debug.Log("2");
            Vector3 handPos = other.transform.position; 
            if(Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f)
            {
                Debug.Log("3");
                Instantiate(rectBlockPrefab, handPos, Quaternion.identity);
            }
        }
    }
}
