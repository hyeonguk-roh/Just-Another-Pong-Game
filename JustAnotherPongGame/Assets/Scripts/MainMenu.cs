using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void computerMatch()
    {
        SceneManager.LoadScene("BotMatch");
    }

    public void friendlyMatch()
    {
        SceneManager.LoadScene("PVP");
    }
}
