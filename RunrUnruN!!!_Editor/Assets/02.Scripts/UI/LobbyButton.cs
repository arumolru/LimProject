using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Lobby");
    }
}
