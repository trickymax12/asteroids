using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float movespeed;
    private Gamemanager Gamemanager;
    public int pointvalue;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("Game manager").GetComponent<Gamemanager>();  
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            movespeed += 1;
            Gamemanager.UpdateScore(pointvalue);
            Destroy(gameObject);
        }
    }
}
