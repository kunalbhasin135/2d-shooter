using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public int health = 100;
	public int damage = 10;
    public HealthBar healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        healthbar.SetHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Hurt(){

    	health = health-damage;
        healthbar.SetHealth(health);
    	if(health<=0){
    		Application.LoadLevel(Application.loadedLevel);
    	}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
        	
            Hurt();
        }
    }

    

    
}

