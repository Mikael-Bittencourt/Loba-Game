using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_movement : MonoBehaviour
{
    public Transform player;
    private void Update()
    {
        transform.position = player.position + new Vector3(0.6f, 0f);
    } 
}
