﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    public int RotateSpeed = 2;
    public AudioSource CollectSound;
    public GameObject ThisObject;
    public Item item;


    void Update()
    {
      
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }


    void OnTriggerEnter()
    {
        Debug.Log("Picking up " + item.name);
        
        bool wasPickedUp = Inventory.instance.Add(item);

        if(wasPickedUp)
        {
            CollectSound.Play();
            Destroy(gameObject);
        }
       
    }
}
