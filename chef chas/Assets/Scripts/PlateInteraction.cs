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
    
  

        //pick up if space bar pressed and plate in range
        if (Pickup.pickUp && inRange){
            
            transform.position = playerHands.transform.position;
            plateRigidbody.isKinematic = true;
            Pickup.handsEmpty = false;
            print("picked up");
        
        }

        //if spacebar pressed run through this
        if (!(Pickup.pickUp) ){
            
            
            //if looking at table place plate on top of table
            if (RaycastView.lookingAtTable){
            
                Vector3 plateHolderPosition = RaycastView.hitObjectTransform.position;
                plateHolderPosition += new Vector3(0.2f, 2.0f, -0.6f);

                transform.position = plateHolderPosition;
                plateRigidbody.isKinematic = true;
                Pickup.handsEmpty = true;
                print("dropped on table");

                RaycastView.lookingAtTable = false;
            }
            
            
            else{
                
                transform.position = transform.position;
                plateRigidbody.isKinematic = false;
                Pickup.handsEmpty = true;
                print("dropped");

                RaycastView.lookingAtTable = false;


            }

        

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