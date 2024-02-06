using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] public float cameraSpeed;
    [SerializeField] Camera camera;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y , transform.position.z), cameraSpeed);
    }
 

}
