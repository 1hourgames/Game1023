using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisionScript : MonoBehaviour
{
    public int ans;
    private string winScene = "Win";

    private string endScene = "Lose";

    public void CorrectAns()
    {
        SceneManager.LoadScene(winScene);
    }
    public void WrongAns()
    {
        SceneManager.LoadScene(endScene);
    }

}
