using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // ���˹觢ͧ����Ф�
    public float rotationSpeed = 1f; // ��������㹡����ع���ͧ

    private Vector3 offset; // ���˹觷���ͧ��������ͧ������ҧ�ҡ����Ф�

    void Start()
    {
        offset = transform.position - target.position; // �ҵ��˹� offset �����ҧ���ͧ�Ѻ����Ф�������������
    }

    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Mouse X"); // �Ѻ��ҡ������͹��Ǣͧ������᡹ X
        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed); // ��ع���ͧ�ͺ����Ф�

        // ��Ѻ���˹觢ͧ���ͧ�������������Ф���������������
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.05f);
    }
}
