using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour {
    public float speed = 1f;
 // Use this for initialization
 void Start () {
 
 }
 
 // Update is called once per frame
 void Update () {
             if (Input.GetKey(KeyCode.Space))
                     transform.position += new Vector3 (speed * Time.deltaTime, 0.1f, 0.0f);
 
 				}
 			}

