using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_bounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(Mathf.Clamp(transform.position.x,-6.56f,9.91f),
        Mathf.Clamp(transform.position.y, -3.98f,-1.77f), transform.position.z); 
    }
}
