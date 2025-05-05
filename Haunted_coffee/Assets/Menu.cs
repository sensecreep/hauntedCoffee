using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void StartSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void StartLoading()
    {
        SceneManager.LoadScene("Loading");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void StartSelectSlot()
    {
        SceneManager.LoadScene("SelectSlot");
    }

    public void OnQuitButtonClick()
    {
        // ��� ���������
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // � ��������� ������
        Application.Quit();
        #endif
    }

}
