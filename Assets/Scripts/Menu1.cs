using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    public static Menu1 menu1;
    public TMP_InputField inputField;

    public string player_name;

    private void Awake()
    {
        if (menu1 == null)
        {
            menu1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        player_name = inputField.text;

        SceneManager.LoadScene(1);
    }

    




}
