using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionHandler : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      var outline = other.gameObject.GetComponent<Outline>();
      outline.OutlineWidth = 2;
      
      Destroy(gameObject);
   }
}
