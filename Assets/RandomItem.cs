using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    public GameObject objectPrefab; // โปรแกรมที่ต้องการสร้าง
    public Vector3 minPosition; // ตำแหน่งสุ่มขั้นต่ำ
    public Vector3 maxPosition; // ตำแหน่งสุ่มสูงสุด

    void Start()
    {
        for (int i = 0; i < 15 ; i++)
        {
            // สร้าง Object โดยสุ่มตำแหน่งในขอบเขตที่กำหนด
            Vector3 randomPosition = new Vector3(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y),
                Random.Range(minPosition.z, maxPosition.z)
            );
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
       
    }
}
