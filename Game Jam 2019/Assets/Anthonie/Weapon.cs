﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        if(collision.transform.tag == "Player")
        {

        }
    }
}
