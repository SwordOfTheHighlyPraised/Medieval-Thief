using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text ScoreText;
    private float score;    



    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player") != null)
            score += 1 * Time.deltaTime;
        ScoreText.text=((int)score).ToString();





    }
    public void addscore(float newscore)
    {
        score += newscore;
    }
}
