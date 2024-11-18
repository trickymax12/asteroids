using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float movespeed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       HorizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * movespeed * HorizontalInput * turnSpeed * Time.deltaTime);
       VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * movespeed * VerticalInput * Time.deltaTime);
    }
}
