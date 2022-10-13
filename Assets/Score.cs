using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtScore;
    public int scorePoints;

    // Start is called before the first frame update
    void Start()
    {
        scorePoints = 0;
        ScoreUpdate();
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    public void AddPoints(int points)
    {
        scorePoints += points;
        ScoreUpdate();
    }
    public void ScoreUpdate()
    {
        txtScore.text = scorePoints.ToString();
    }
}
