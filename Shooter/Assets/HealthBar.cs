using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image circle;
    

	void start(){
		circle = this.GetComponent<Image>();
	}


    public void SetHealth(int health){
    	circle.fillAmount = health;
    }
}
