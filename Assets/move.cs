using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        rb.velocity = Vector3.right * 4 * Input.GetAxisRaw("Horizontal");
        rb.velocity = Vector3.up * 4 * Input.GetAxisRaw("Vertical");
    }
}
