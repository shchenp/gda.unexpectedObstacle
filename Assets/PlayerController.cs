using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private MovementController _movementController;
    
    [SerializeField]
    private LayerMask _layerMask;

    private Camera _camera;
    
    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        var ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hitInfo, 50f, _layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                _movementController.GetPointToMove(hitInfo);
            }
        }
    }
}
