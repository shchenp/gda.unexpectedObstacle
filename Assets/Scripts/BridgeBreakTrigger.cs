using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBreakTrigger : MonoBehaviour
{
   [SerializeField]
   private Bridge _bridge;
   private void OnTriggerEnter(Collider playerCollider)
   {
      _bridge.Break();
   }
}
