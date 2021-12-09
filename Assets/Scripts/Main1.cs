using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main1 : MonoBehaviour
{
    public TextMeshProUGUI display_player_name;
    

    public void Awake()
    {
        display_player_name.text = Menu1.menu1.player_name;
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene(0);
    }

}
