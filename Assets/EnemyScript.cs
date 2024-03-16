using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -0.1f);

        if (transform.position.z < -2)
        {
            Destroy(this.gameObject);
        }
    }
}
