using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatie : MonoBehaviour
{
    public Rigidbody rb;
    public float Viteza = 10f;
    private float xInput;
    private float zInput;
    public float saritura = 5f;
    private bool pePamant = true;
    private const int dubla = 2;
    private int sarituraCurenta = 0;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessInputs();
        Jump();
    }
    private void FixedUpdate()
    {
        Miscare();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Miscare()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * Viteza);
    }
    private void Jump()
    {
        if(Input.GetKeyDown("space") && (pePamant || dubla > sarituraCurenta))
        {
            rb.AddForce(Vector3.up * saritura, ForceMode.Impulse);
            pePamant = false;
            sarituraCurenta++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        pePamant = true;
        sarituraCurenta = 0;

    }
}
