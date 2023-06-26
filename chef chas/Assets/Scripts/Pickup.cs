using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : MonoBehaviour
{
    
    public static bool pickUp; 
    public static bool handsEmpty;


    void Start(){

        handsEmpty = true;
        pickUp = false;
    }
    
    void Update()
    {
        if (handsEmpty == true && Input.GetKeyDown("space"))
        {
            print("space presed");
            pickUp = true;
            
            
        }

        if (handsEmpty == false && Input.GetKeyDown("space")){
            
            pickUp = false;
            
        }
    }
}
