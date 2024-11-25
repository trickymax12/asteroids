using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnmanager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    //[SerializeField] private GameObject textBox;
    [SerializeField] private GameObject player;

    [SerializeField] private int enemies;
    [SerializeField] private int waves = 1;
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

        Spawn(waves);
    }
    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-20, 20);
        float spawnPosZ = Random.Range(-15, 15);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    void Spawn(int enemies)
    {
        for (int i = 0; i < enemies; i++)
        {
            Instantiate(enemy, GenerateSpawnPos(), enemy.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemies = FindObjectsOfType<astroid>().Length;
        if (enemies == 0)
        {
            waves++;
            Spawn(waves);
        }
        //if (player.activeInHierarchy == false)
       // {
            //textBox.SetActive(true);
        //}
    }
}

