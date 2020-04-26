using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(myRay, out hitinfo))
            {
                if (hitinfo.collider.CompareTag("Object"))
                {
                    Rigidbody rb = hitinfo.collider.GetComponent<Rigidbody>();
                    if (rb)
                    {
                        rb.AddForce(-hitinfo.normal, ForceMode.Impulse);
                    }
                } 
            }
        }
    }

    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
