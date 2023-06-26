using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateInteraction : MonoBehaviour
{
    public static bool inRange = false;
    public GameObject playerHands;
    private Rigidbody plateRigidbody;

    void Start(){
        plateRigidbody = GetComponent<Rigidbody>();
    }
    
    void Update(){
    
        if (Pickup.pickUp && inRange){
            
           transform.position = playerHands.transform.position;
           plateRigidbody.isKinematic = true;
           Pickup.handsEmpty = false;
           print("picked up");
           
        }

        if (!(Pickup.pickUp) ){
            
           transform.position = transform.position;
           plateRigidbody.isKinematic = false;
           Pickup.handsEmpty = true;
           print("dropped");
          

        }


    }

    void OnTriggerEnter(Collider other) {
       
        if (other.tag == ("Player"))
        {
            print("can pick up");
            inRange = true;
            

        }
    }

    void OnTriggerExit(Collider other) {
        
        if (other.tag == ("Player"))
        {
            print("can pick up");
            inRange = false;
            

        }
    }
    }
    

