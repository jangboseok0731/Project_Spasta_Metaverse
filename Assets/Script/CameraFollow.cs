using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFllow : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f;
    public Vector3 offset = new Vector3(0,0,-3.5f);



    private void LateUpdate()
    {
        if (target == null)
            return;
        Vector3 targetPosition = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed);
    }


}
