using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
	Pooler pooler;
    // Start is called before the first frame update
    private void Start()
    {
        pooler = Pooler.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
    }
}
