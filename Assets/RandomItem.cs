using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    public GameObject objectPrefab; // ���������ͧ������ҧ
    public Vector3 minPosition; // ���˹�������鹵��
    public Vector3 maxPosition; // ���˹������٧�ش

    void Start()
    {
        for (int i = 0; i < 15 ; i++)
        {
            // ���ҧ Object ���������˹�㹢ͺࢵ����˹�
            Vector3 randomPosition = new Vector3(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y),
                Random.Range(minPosition.z, maxPosition.z)
            );
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
       
    }
}
