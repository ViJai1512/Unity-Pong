using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorecontrol : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject p1s;
    public GameObject p2s;

    public int ToWin;

    // Update is called once per frame
    void Update()
    {
        if(this.scorePlayer1 >= this.ToWin || this.scorePlayer2 >= this.ToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("gameover");
        }
        
    }
    private void FixedUpdate()
    {
        Text uiScorePlayer1=this.p1s.GetComponent<Text>();
        uiScorePlayer1.text=this.scorePlayer1.ToString();

        Text uiScorePlayer2 = this.p2s.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }
    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
