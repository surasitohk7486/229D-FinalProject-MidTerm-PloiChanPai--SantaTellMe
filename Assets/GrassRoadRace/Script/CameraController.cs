using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // ตำแหน่งของตัวละคร
    public float rotationSpeed = 1f; // ความเร็วในการหมุนกล้อง

    private Vector3 offset; // ตำแหน่งที่ต้องการให้กล้องอยู่ห่างจากตัวละคร

    void Start()
    {
        offset = transform.position - target.position; // หาตำแหน่ง offset ระหว่างกล้องกับตัวละครเมื่อเริ่มเกม
    }

    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Mouse X"); // รับค่าการเคลื่อนไหวของเมาส์ในแกน X
        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed); // หมุนกล้องรอบตัวละคร

        // ปรับตำแหน่งของกล้องให้อยู่ใกล้ตัวละครเมื่อเกมเริ่มต้น
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.05f);
    }
}
