using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float m_BaseJumpPower = 5f;
    [SerializeField] float m_maxJumpPower = 10f;
    [SerializeField] float m_maxRayDistance = 2f;
    [SerializeField] Mesh[] m_meshs;
    MeshFilter m_baseMesh;

    int m_meshIndex;
    Rigidbody m_rb;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_baseMesh = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_BaseJumpPower > m_maxJumpPower) m_BaseJumpPower = m_maxJumpPower;

        if (Input.GetButtonDown("Fire1"))
        {
            //destPoint = (destPoint + 1) % points.Length;
            m_meshIndex = (m_meshIndex + 1) % m_meshs.Length;
            m_baseMesh.mesh = m_meshs[m_meshIndex];

        }
        if (IsGround())
        {
            if (Input.GetButton("Jump"))
            {
                m_BaseJumpPower += 0.01f;
                Debug.Log(m_BaseJumpPower);
            }
            if (Input.GetButtonUp("Jump")) Jump();
        }
        else
        {
            Debug.Log("notIsGround");
            m_BaseJumpPower = 5f;
        }
    }

    void Jump()
    {
        m_rb.AddForce(Vector3.up * m_BaseJumpPower, ForceMode.Impulse);
    }
    bool IsGround()
    {
        bool isGround = Physics.Raycast(this.transform.position + Vector3.up * 0.5f, Vector3.down, m_maxRayDistance);
        Debug.DrawRay(this.transform.position, Vector3.down * m_maxRayDistance, Color.red);
        return isGround;
    }
}
