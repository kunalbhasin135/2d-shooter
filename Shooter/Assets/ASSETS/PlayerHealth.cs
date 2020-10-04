using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int maxhealth = 100;
	public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D hitInfo){
    	if(hitInfo.tag == "Enemy"){
    		Takedamage(20);
    	}
    }

    void Takedamage(int damage){
    	currentHealth -= damage;
    }
}
