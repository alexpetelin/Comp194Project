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
             transform.GetComponent<Renderer> ().material.color = pbyellow;
         }
 
         if (transform.tag == "bucketgray") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbgray;
         }

         if (transform.tag == "bucketwhite") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbwhite;
         }

         if (transform.tag == "bucketred") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbred;
         }

         if (transform.tag == "bucketbrown") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbbrown;
         }

         if (transform.tag == "bucketgreen") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbgreen;
         }

         if (transform.tag == "bucketblack") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbblack;
         }

         if (transform.tag == "bucketblue") 
         {            
             transform.GetComponent<Renderer> ().material.color = pbblue;
         }









         
         }
    

}
