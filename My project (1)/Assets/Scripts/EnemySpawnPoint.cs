using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public GameObject naAgent;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 1);
    }

    void SpawnEnemy()
    {
        GameObject na = (GameObject)Instantiate(naAgent, this.transform.position, Quaternion.identity);        
    }
}
