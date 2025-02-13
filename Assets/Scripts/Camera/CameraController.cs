using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private float currentZoom = 10f;

    public float minZoom = 7f;
    public float maxZoom = 10f;
    public float zoomSpeed = 3f;

    public float turnInput;
    public float turnSpeed = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        turnInput -= Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;    }
    private void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up);

        transform.RotateAround(target.position,Vector3.up, turnInput);
    }
}
