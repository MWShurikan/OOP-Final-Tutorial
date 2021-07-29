using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int pointsPerSec = 1;
    public bool alive = true;
    private float elapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        string playerName = GameObject.Find("PlayerManager").GetComponent<PlayerManager>().playerName;
        GameObject.Find("PlayerNameText").GetComponent<Text>().text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            score += pointsPerSec;
            GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + score;
        }
    }
}
