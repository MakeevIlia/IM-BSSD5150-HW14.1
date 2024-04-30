using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureController : MonoBehaviour
{
    // Start is called before the first frame update
    public void MakeCoin()
    {
        GameObject coin = Instantiate(Resources.Load("Coin"), transform.position, Quaternion.identity) as GameObject;
        DontDestroyOnLoad(coin);
        Destroy(gameObject);
    }
}
