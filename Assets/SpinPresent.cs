using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPresent: MonoBehaviour
{
    public float rotationSpeed = 50f; // ��������㹡����ع
    void Update()
    {
        // ��ع����᡹ Y (����ö����¹᡹�����ͧ���)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
