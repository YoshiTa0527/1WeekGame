using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] float m_distanceToPlayer = 10f;
    [SerializeField] float m_moveSpd = 5f;

    bool m_isVisible = true;
    GameObject m_player;
    Rigidbody m_rb;
    /// <summary>オブジェクトが画面内にあるかどうかを返す</summary>
    public bool IsVisible
    {
        get { return m_isVisible; }
    }
    private void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (!m_player) return;
        if (!m_isVisible && Vector3.Distance(this.gameObject.transform.position, m_player.transform.position) < m_distanceToPlayer)
        {
            Destroy(this.gameObject);
            Debug.Log("InVisible");
        }

        m_rb.velocity = Vector3.back * m_moveSpd;

    }
    private void OnBecameVisible()
    {
        m_isVisible = true;
        Debug.Log("OnBecameVisible()");
    }

    private void OnBecameInvisible()
    {
        m_isVisible = false;
        Debug.Log("OnBecameInvisible()");
    }
}
