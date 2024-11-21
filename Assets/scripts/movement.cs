using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float movespeed;
    public float turnSpeed;
    public GameObject bulletPrefab;
    public int lives = 1;
    public bool GameIsActive;
    // Start is called before the first frame update
    void Start()
    {
        GameIsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
       HorizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * movespeed * HorizontalInput * turnSpeed * Time.deltaTime);
       VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * movespeed * VerticalInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("astroid"))
        {
            lives -= 1;
            GameOver();
        }
    }
    private void GameOver()
    {
        GameIsActive = false;
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
    }
}
