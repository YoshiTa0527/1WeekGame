
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LoopFloor : MonoBehaviour
{
    /// <summary>動かす速度</summary>
    [SerializeField] float m_speed = 20f;
    /// <summary>動かす方向</summary>
    [SerializeField] Vector3 m_moveDir = Vector3.back;
    /// <summary>この距離移動したら最初の位置に戻る</summary>
    [SerializeField] float m_MaxMoveDis = 20f;
    Vector3 m_startPosition;
    Rigidbody m_rb;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_startPosition = this.transform.position;
    }

    private void Update()
    {
        float moveDistance = Vector3.Distance(this.transform.position, m_startPosition);
        if (moveDistance >= m_MaxMoveDis)
        {
            this.transform.position = m_startPosition;
        }

        Vector3 velo = m_moveDir * m_speed;
        m_rb.velocity = velo;
    }


}