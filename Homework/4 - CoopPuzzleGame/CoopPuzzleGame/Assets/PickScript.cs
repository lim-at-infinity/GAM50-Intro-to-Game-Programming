﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickScript : MonoBehaviour
{
    public GameObject gate = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TPlayer")
        {
            gate.SetActive(false);
            print("Gate unlocked!");
        }
    }
}
