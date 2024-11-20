using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public Rigidbody bulletRb;
    public float moveSpeed;
    public float XRange;
    public float YRange;
    // Start is called before the first frame update
    void Start()
    {
      bulletRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("astroid"))
        {
            Destroy(gameObject);
        }
    }
}
