using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinDropper : MonoBehaviour
{
    [SerializeField]
    GameObject ContButton;

    // Start is called before the first frame update
    void Start()
    {
        ContButton.SetActive(false);
        float topY = transform.position.y;
        Rigidbody2D[] coins = FindObjectsOfType<Rigidbody2D>();
        foreach (Rigidbody2D coin in coins)
        {
            coin.position = new Vector2(coin.position.x, topY - coin.position.y);
            coin.gravityScale = 1f;
        }
    }

    private void Update()
    {
        Rigidbody2D[] coins = FindObjectsOfType<Rigidbody2D>();
        if (coins.Length == 0) 
        {
            ContButton.SetActive(true);
        }
    }

    public void BackToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
