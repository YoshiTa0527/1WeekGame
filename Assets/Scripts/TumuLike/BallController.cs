using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    [SerializeField] float m_pushPower = 1f;
    Rigidbody m_rb;
    private void Start()
    {
        float random = Random.Range(-1f, 1f);
        m_rb = GetComponent<Rigidbody>();
        m_rb.AddForce(new Vector2(random, 0) * m_pushPower, ForceMode.Impulse);
    }
}
