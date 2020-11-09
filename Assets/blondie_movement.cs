using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blondie_movement : MonoBehaviour
{
    public float blondie_movementSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var blondie_movement = Input.GetAxis("Horizontal"); 
        transform.position += new Vector3(blondie_movement,0,0)* Time.deltaTime * blondie_movementSpeed;
    }
}
