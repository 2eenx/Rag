using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text PlayerNames;

    void start()
    {

        PlayerNames.text = PlayerData.Instance.PlayerName();

    }


}


   

