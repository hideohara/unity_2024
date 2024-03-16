using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //public GameObject GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 0.2f);

        if (transform.position.z > 30)
        {
            Destroy(this.gameObject);
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit"); // ÉçÉOÇï\é¶Ç∑ÇÈ
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            GameManagerScript.gameScore += 1;
            //GameManagerScript.AddScore();

        }
    }
}
