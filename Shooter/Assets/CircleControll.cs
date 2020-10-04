using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleControll : MonoBehaviour
{
	public int maxHP;
	public float hp;
	public Image health;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = 100;
        hp = 0;

    }

    // Update is called once per frame
    void Update()
    {
        hp+= maxHP;
        health.fillAmount = hp;
         
    }
}
