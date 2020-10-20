using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBucketColors : MonoBehaviour
{
 
     public Color pbyellow;
     public Color pbgray;
     public Color pbwhite;
     public Color pbred;
     public Color pbbrown;
     public Color pbgreen;
     public Color pbblack;
     public Color pbblue; 
 
     void OnCollisionEnter(Collision other) {
         if (transform.tag == "bucketyellow") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbyellow;
         }
 
         if (transform.tag == "bucketgray") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbgray;
         }

         if (transform.tag == "bucketwhite") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbwhite;
         }

         if (transform.tag == "bucketred") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbred;
         }

         if (transform.tag == "bucketbrown") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbbrown;
         }

         if (transform.tag == "bucketgreen") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbgreen;
         }

         if (transform.tag == "bucketblack") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbblack;
         }

         if (transform.tag == "bucketblue") 
         {            
             other.transform.GetComponent<Renderer> ().material.color = pbblue;
         }









         
         }
    

}
