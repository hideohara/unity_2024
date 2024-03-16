using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float xSpeed=0;

    private GameObject gameManager; // �I�u�W�F�N�g������ϐ�
    private GameManagerScript gameManagerScript; // Script������ϐ�

    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���}�l�[�W���[�̃X�N���v�g��T��
        gameManager = GameObject.Find("GameManager"); // �I�u�W�F�N�g�̖��O����T��
        gameManagerScript = gameManager.GetComponent<GameManagerScript>(); // Script���擾����

        // �����ō��E��
        int r = Random.Range(0, 2);
        if (r==0)
        {
            xSpeed = 0.05f;
            transform.rotation = Quaternion.Euler(0, 180-20, 0);
        }
        else
        {
            xSpeed = -0.05f;
            transform.rotation = Quaternion.Euler(0, 180+20, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // �Q�[���I�[�o�[
        if (gameManagerScript.GetGameOverFlag() == true)
        {
            return;
        }

        // �ړ�
        transform.position += new Vector3(xSpeed, 0, -0.1f);

        // ���E�Ŕ��]
        if (transform.position.x>4)
        {
            xSpeed = -0.05f;
            transform.rotation = Quaternion.Euler(0, 180 + 20, 0);
        }
        if (transform.position.x < -4)
        {
            xSpeed = 0.05f;
            transform.rotation = Quaternion.Euler(0, 180 - 20, 0);
        }

        // ��O�ŏ���
        if (transform.position.z < -2)
        {
            Destroy(this.gameObject);
        }
    }
}
