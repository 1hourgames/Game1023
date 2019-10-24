using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class CountdownTimer : MonoBehaviour
{
    public float timeLimit;
    public TextMeshProUGUI timerText;

    public GameObject panel1;
    public GameObject panel2;

    public GameObject button1;
    public GameObject button2;

    private string endScene = "Lose";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if(timeLimit < 20)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);

        }

        if(timeLimit < 0)
        {
            SceneManager.LoadScene(endScene);
        }
        timerText.text = "Time: " + timeLimit.ToString("0.00");
    }
}
