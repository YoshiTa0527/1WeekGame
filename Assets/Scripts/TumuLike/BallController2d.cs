using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController2d : MonoBehaviour
{
    [SerializeField] float m_pushPower = 1f;
    Rigidbody2D m_rb;

    // Start is called before the first frame update
    void Start()
    {
        float random = Random.Range(-1f, 1f);
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.AddForce(new Vector2(random, 0) * m_pushPower, ForceMode2D.Impulse);
    }
}
