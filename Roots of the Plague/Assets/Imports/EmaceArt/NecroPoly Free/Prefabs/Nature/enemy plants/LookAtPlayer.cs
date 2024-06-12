using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;

    
    void Update()
    {
        
        Vector3 direction = player.position - transform.position;
        direction.y = 0; 

       
        if (direction.sqrMagnitude > 0.01f)
        {
           
            Quaternion rotation = Quaternion.LookRotation(direction);

            
            transform.rotation = rotation;
        }
    }
}
