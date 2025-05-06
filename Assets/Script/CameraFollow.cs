using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;             // ตัวละคร
    public float smoothSpeed = 0.125f;   // ความนุ่มนวลของการติดตาม
    public Vector3 offset = new Vector3(0f, 0f, -10f); // กล้องต้องอยู่ด้านหลัง

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}