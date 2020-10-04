using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
	public float health = 100f;
	public GameObject effect;
    public int scoreValue = 10;

    private Shake shake;
    // Start is called before the first frame update
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            shake.camShake();
        	Instantiate(effect, transform.position, Quaternion.identity);
            ScoreManager.score += scoreValue;
        	Destroy (gameObject);
        }
    }

    void Damage(float hit){
    	health -= hit;
    }
}
