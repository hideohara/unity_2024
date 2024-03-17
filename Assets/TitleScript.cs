using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public GameObject enterText;
    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");
        }

        timer++;
        if (timer % 100 > 50)
        {
            enterText.SetActive(false);
        }
        else
        {
            enterText.SetActive(true);
        }
    }
}
