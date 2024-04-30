using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class KeyboardController : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputField;

    private TreasureController[] treasures;
    private int keyCount = 0;
    private void Awake()
    {
        treasures = FindObjectsOfType<TreasureController>();
    }
    public void Logkey(string key)
    {
        keyCount++;
        if (keyCount > 3)
        {
            SceneManager.LoadScene("ScoreScene");
        }
        char typed = inputField.text[inputField.text.Length - 1];
        int code = (int)typed;

        code = code - 97;

        if (code >= 0 && code < treasures.Length)
        {
            if (treasures[code] != null)
            {
                treasures[code].MakeCoin();
            }
        }
    }
}
