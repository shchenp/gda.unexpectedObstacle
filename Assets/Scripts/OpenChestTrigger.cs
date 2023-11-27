using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChestTrigger : MonoBehaviour
{
   [SerializeField]
   private Chest _chest;

   private void OnTriggerEnter(Collider other)
   {
     _chest.Open();
   }
}
