using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    public Animator animator;

    private int bulletTimer = 0;

    private GameObject gameManager; // �I�u�W�F�N�g������ϐ�
    private GameManagerScript gameManagerScript; // Script������ϐ�


    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���}�l�[�W���[�̃X�N���v�g��T��
        gameManager = GameObject.Find("GameManager"); // �I�u�W�F�N�g�̖��O����T��
        gameManagerScript = gameManager.GetComponent<GameManagerScript>(); // Script���擾����

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.GetGameOverFlag() == true)
        {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 4)
            {
                transform.position += new Vector3(0.05f, 0, 0);
                //rb.velocity = new Vector3(1, 0, 0);
            }
            animator.SetBool("Move", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -4)
            {
                transform.position += new Vector3(-0.05f, 0, 0);
                //rb.velocity = new Vector3(-1, 0, 0);
            }
            animator.SetBool("Move", true);
        }
        else 
        {
            animator.SetBool("Move", false);
            //rb.velocity = new Vector3(0, 0, 0);
        }

        if (bulletTimer == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Vector3 position = transform.position;
                position.y += 0.8f;
                position.z += 0.5f;

                Instantiate(bullet, position, Quaternion.identity);
                bulletTimer = 1;
            }
        }
        else
        {
            bulletTimer++;
            if (bulletTimer > 20)
            { 
                bulletTimer = 0;
            }
        }

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("GameOver"); // ���O��\������

            gameManagerScript.SetGameOverFlag();
        }
    }

}
