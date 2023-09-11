using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SunRotation : MonoBehaviour
{
    [SerializeField] private bool _followCamera;
    [SerializeField] private float _rotationSpeed, _cloudOffsetSpeed;
    [SerializeField] private Vector2 _cloudOffset = Vector2.zero;
    [SerializeField] private Material _skyboxMaterial;

    private void Update()
    {
        _cloudOffset.x += _cloudOffsetSpeed * Time.deltaTime;

        Vector3 rotation = new(
            _rotationSpeed * Time.deltaTime,
            0,
            0
            );

        transform.Rotate(rotation);
        _skyboxMaterial.SetVector("_Cloud_Offset", _cloudOffset);
    }
}
