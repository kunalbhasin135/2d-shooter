using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
	public Transform[] spawnPoints;
	public GameObject[] enemies;
	int randomSpawn,randomEnemy;
	public static bool spawnAllowed;
    // Start is called before the first frame update
    void Start()
    {
    	spawnAllowed = true;
    	InvokeRepeating("SpawnEnemy", 0f,1f);
        
    }

    void SpawnEnemy(){
    	if(spawnAllowed){
    		randomSpawn = Random.Range(0, spawnPoints.Length);
    		randomEnemy = Random.Range(0, enemies.Length);
    		Instantiate(enemies[randomEnemy], spawnPoints[randomSpawn].position, Quaternion.identity);
    		
    	}
    }
}
