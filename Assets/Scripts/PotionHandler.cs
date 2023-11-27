using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionHandler : MonoBehaviour
{
   [SerializeField] 
   private BridgeBreakTrigger _bridgeTrigger;
   private void OnTriggerEnter(Collider other)
   {
      var outline = other.gameObject.GetComponent<Outline>();
      outline.OutlineWidth = 2;

      Destroy(_bridgeTrigger);
      Destroy(gameObject);
   }
}
