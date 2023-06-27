using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastView : MonoBehaviour
{
    public Material outlineMaterial;
    public static bool placeOnTable;
    public static Transform hitObjectTransform;
    
    private Renderer hitObjectRenderer;
    private Material previousMaterial;

    void Start()
    {
        
    }

    void Update()
    {
        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 1.5f)))
        {
            
            GameObject hitObject = hitInfo.collider.gameObject;
            hitObjectTransform = hitObject.GetComponent<Transform>();
            
            
            //print(selectedTablePlateHolder.position);
            
            if (hitObject.tag == ("placeable")){   
                
                placeOnTable = true;

                hitObjectRenderer = hitObject.GetComponent<Renderer>();
                if (previousMaterial == null)
                {
                    previousMaterial = hitObjectRenderer.material;
                }

                hitObjectRenderer.material = outlineMaterial;
            }
        }
        else
        {

            if (hitObjectRenderer != null && previousMaterial != null)
                {
                    
                    hitObjectRenderer.material = previousMaterial;
                    previousMaterial = null;
                
            }
        }
    }
}
