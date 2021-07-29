using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public string playerName = "";

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
