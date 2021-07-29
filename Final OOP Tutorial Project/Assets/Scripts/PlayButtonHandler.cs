using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonHandler : MonoBehaviour
{
   public void startGame()
    {
        PlayerManager playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        playerManager.playerName = GameObject.Find("PlayerNameField").GetComponent<InputField>().text;
        SceneManager.LoadScene("Main");
    }
}
