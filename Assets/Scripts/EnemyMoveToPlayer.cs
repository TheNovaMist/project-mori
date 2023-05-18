using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target; // 寻路的目标位置
    public float MoveSpeed = 3f; // 移动速度
    private NavMeshAgent navMeshAgent; // 寻路组件
    void Start()
    {
        // 如果没有寻路组件则挂载
        if(navMeshAgent == null)
        {
            navMeshAgent = gameObject.AddComponent<NavMeshAgent>();
        }
        // 获取player位置与寻路组件
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
        // 速度
        navMeshAgent.speed = MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // 设置寻路目标
        navMeshAgent.SetDestination(target.transform.position);
    }
}
