using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform target; // ตำแหน่งของตัวละครที่ต้องการให้กล้องตาม
    public Vector3 offset; // ระยะห่างระหว่างกล้องกับตัวละคร

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset; // ตำแหน่งของกล้องเป็นตำแหน่งของตัวละครบวกกับ offset
        }
    }
}
