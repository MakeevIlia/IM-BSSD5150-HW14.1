using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TextMeshProUGUI[] texts = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI text in texts)
        {
            if (text.gameObject.tag == "Score")
            {
                TextMeshProUGUI scoreText = text;
                int score = int.Parse(scoreText.text);
                scoreText.text = (score + 1).ToString();
                Destroy(this.gameObject);
            }
        }
    }
}
