using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target; // Ѱ·��Ŀ��λ��
    public float MoveSpeed = 3f; // �ƶ��ٶ�
    private NavMeshAgent navMeshAgent; // Ѱ·���
    void Start()
    {
        // ���û��Ѱ·��������
        if(navMeshAgent == null)
        {
            navMeshAgent = gameObject.AddComponent<NavMeshAgent>();
        }
        // ��ȡplayerλ����Ѱ·���
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
        // �ٶ�
        navMeshAgent.speed = MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // ����Ѱ·Ŀ��
        navMeshAgent.SetDestination(target.transform.position);
    }
}
