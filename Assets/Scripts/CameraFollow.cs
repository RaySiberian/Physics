using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTo;
    private readonly Vector3 offset = new Vector3(0, 9, -8);
    private void FixedUpdate()
    {
        transform.position = followTo.transform.position + offset;
    }
}
