using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    public float moveSpeed;
    public GameObject astroidprefab;
    public int pointvalue;
    private Gamemanager Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("Game manager").GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            moveSpeed += 1;
            Instantiate(astroidprefab, transform.position, transform.rotation);
            Gamemanager.UpdateScore(pointvalue);
            Destroy(gameObject);
        }
    }
}
