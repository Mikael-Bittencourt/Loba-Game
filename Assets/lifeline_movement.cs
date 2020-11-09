using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeline_movement : MonoBehaviour
{
   public float lifeline_movementSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var lifeline_movement = Input.GetAxis("Horizontal"); 
        transform.position += new Vector3(lifeline_movement,0,0)* Time.deltaTime * lifeline_movementSpeed;
    }
}
