using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraSize : MonoBehaviour
{
    [SerializeField] Camera camera;
    private float cameraSize = 5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CameraTrigger")
        {
            // Kamera büyüklüðünü 3 saniyede 5f'e çýkartýr.
            DOTween.To(x => camera.orthographicSize = x, camera.orthographicSize, cameraSize, 3);
        }
    }
    
}
