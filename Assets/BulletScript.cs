using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletScript : MonoBehaviour
{
    private GameObject gameManager; // GameObject���̂��̂�����ϐ�
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
            //Debug.Log("Hit"); // ���O��\������
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            gameManagerScript.AddScore();

        }
    }
}
