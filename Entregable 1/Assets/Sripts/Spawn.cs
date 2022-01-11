using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 spawnPos;
    public int left = 0;
    public int right = 1;
    private Quaternion roffset = Quaternion.Euler(0, 180, 0);

    public float randomY;
    private int randomX;

    public float startDelay = 0.5f;
    public float repeatRate = 2f;
    
    


    void Start()
    {
        
        
        
        InvokeRepeating("SpawnRandom", startDelay, repeatRate);

       
    }

    void update()
    {
        repeatRate = Random.Range(1, 10);
    }

    public void SpawnRandom()
    {
       
        Instantiate(prefab, spawnPos, prefab.transform.rotation);
        

    }
}
