using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastView : MonoBehaviour
{
    public Material outlineMaterial;
<<<<<<< HEAD
    public static bool lookingAtTable;
    public static Transform hitObjectTransform;
    
=======
>>>>>>> parent of 300701e (place between tables)
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
            
            
            if (hitObject.tag == ("placeable")){   
                
<<<<<<< HEAD
                lookingAtTable = true;

=======
>>>>>>> parent of 300701e (place between tables)
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
