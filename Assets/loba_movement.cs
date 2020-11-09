using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loba_movement : MonoBehaviour
{
   public float loba_movementSpeed = 1;
   public loba_movement movement;
    void Start()
    {

      Time.timeScale = 1;
 
    }

    // Update is called once per frame
    void Update()
    {
        var loba_movement = Input.GetAxis("Horizontal"); 
        transform.position += new Vector3(loba_movement,0,0)* Time.deltaTime * loba_movementSpeed;
        
          
        

    } 

    
    
    
}
