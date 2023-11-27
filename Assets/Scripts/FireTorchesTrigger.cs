using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTorchesTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _fire;
    private void OnTriggerEnter(Collider other)
    {
        _fire.SetActive(true);
    }
}
