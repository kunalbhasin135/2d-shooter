using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public Rigidbody2D rb;
	public float destroy = 1.0f;
	public float damage = 10f;
    
    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;
        Invoke("Kill", destroy);
    }

    void OnTriggerEnter2D (Collider2D hitInfo){
    	if(hitInfo.tag == "Enemy"){

    		hitInfo.SendMessage("Damage",damage,SendMessageOptions.DontRequireReceiver);
    		Destroy(gameObject);
    	}
    	
    	
    	
    }

    void Kill(){
    	Destroy (gameObject);
    }

   
}
