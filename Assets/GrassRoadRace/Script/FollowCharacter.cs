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

    public Transform target; // ���˹觢ͧ����Ф÷���ͧ��������ͧ���
    public Vector3 offset; // ������ҧ�����ҧ���ͧ�Ѻ����Ф�

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset; // ���˹觢ͧ���ͧ�繵��˹觢ͧ����Фúǡ�Ѻ offset
        }
    }
}
