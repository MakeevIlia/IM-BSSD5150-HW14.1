using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int bestScore = 0;
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Record");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI[] texts = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI text in texts)
        {
            if (text.gameObject.tag == "Score")
            {
                TextMeshProUGUI scoreText = text;
                int score = int.Parse(scoreText.text);
                bestScore = Mathf.Max(score, bestScore);
            }

            if (text.gameObject.tag == "BestScore")
            {
                TextMeshProUGUI bestRecord = text;
                bestRecord.text = "Best Score: " + bestScore.ToString();
            }
        }
    }
}
