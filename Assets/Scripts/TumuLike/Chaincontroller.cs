using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaincontroller : MonoBehaviour
{
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            
            if (Physics.Raycast(ray,out hit, 100f))
            {
                if (hit.collider.tag == "Ball")
                {
                    //Destroy(hit.collider.gameObject);
                    //hit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(1f, 1f, 0, 0.5f));

                }
            }
        }
    }
}
