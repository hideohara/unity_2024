using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    private int gameTime = 0;
    public static int gameScore = 0;
    public static bool gameOverFlag = false;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject enterText;

    //GameObject unitychan; //Unity����񂻂̂��̂�����ϐ�
    //PlayerScript script; //UnityChanScript������ϐ�

    // Start is called before the first frame update
    void Start()
    {
        //unitychan = GameObject.Find("unitychan"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        //script = unitychan.GetComponent<PlayerScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverFlag == true)
        {
            gameOverText.SetActive(true);
            enterText.SetActive(true);
            return;
        }

        gameTime++;
        int max;
        max = 100 - gameTime / 100;
        if (max < 20) max = 20;
        int r = Random.Range(0, max);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0.0f, 15), Quaternion.identity);
        }

        scoreText.text = "SCORE " + gameScore;

    }

    //static public void AddScore()
    //{
    //    gameScore += 1;
    //}

    //public void SetGameOver()
    //{
    //    gameOverFlag = true;
    //    //gameOverText.SetActive(false);
    //}

}
