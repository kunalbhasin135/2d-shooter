using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float firespeed;
    public float canFire;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")&& Time.time> canFire){

        	Shoot();
        	canFire = Time.time + firespeed;
        }

    }

    void Shoot(){
    	Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    }

}
