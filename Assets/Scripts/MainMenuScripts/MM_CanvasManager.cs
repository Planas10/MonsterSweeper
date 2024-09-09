using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MM_CanvasManager : MonoBehaviour
{
    public GameObject _MainCanvas;
    public GameObject _SettingsCanvas;

    private void Awake()
    {
        _MainCanvas.SetActive(true);
        _SettingsCanvas.SetActive(false);
    }

    //Start Game
    public void PressStart() {
        SceneManager.LoadScene("MainScene");
    }

    //Open Settings
    public void PressSettings() {
        _MainCanvas.SetActive(false);
        _SettingsCanvas.SetActive(true);
    }

    //Quit Game
    public void PressQuit() {
        Application.Quit();
    }

    public void BackFromSettings() {
        _MainCanvas.SetActive(true);
        _SettingsCanvas.SetActive(false);
    }
}
