using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI[] scoreText;
    public TextMeshProUGUI[] randomScore;
    // Start is called before the first frame update
    void Start()
    {
        //Score of main player
        int score = PlayerPrefs.GetInt("Score");
        scoreText[0].text = score.ToString();
        scoreText[1].text = score.ToString();

        int lastValue = score;

        //Random Score values to random players
        for (int i = 0; i < randomScore.Length; i++)
        {
            int randomNumber;
            do{
                randomNumber = UnityEngine.Random.Range(0, score);
            }while(randomNumber > lastValue);
            lastValue = randomNumber;
            randomScore[i].text = randomNumber.ToString();
        }
    }

}
