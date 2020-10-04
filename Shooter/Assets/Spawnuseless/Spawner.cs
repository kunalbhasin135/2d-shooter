using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject Enemy;
	float randx;
	Vector2 whereToSpawn;
	
	float nextSpawn = 0.0f;
	public float spawnMostWait;
	public float spawnleastWait;
	public int startWait;
	public float spawnWait;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
    	spawnWait = Random.Range(spawnleastWait, spawnMostWait);

        if(Time.time> nextSpawn){
        	nextSpawn = Time.time + spawnWait;
        	randx = Random.Range(-8.4f,8.4f);
        	whereToSpawn = new Vector2(randx, transform.position.y);
        	Instantiate(Enemy,whereToSpawn,Quaternion.identity);
        }
    }

    IEnumerator waitSpawner(){
    	yield return new WaitForSeconds(startWait);

    	while(true){
    		yield return new WaitForSeconds(spawnWait);

    	}
    }




}
