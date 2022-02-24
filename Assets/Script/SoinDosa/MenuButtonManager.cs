﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private GameObject exitPanel;
    [SerializeField]
    private GameObject goToLobbyPanel;
    private bool isOnePanelOpen = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isOnePanelOpen)
            AllPanelClose();
        else if (Input.GetKeyDown(KeyCode.Escape) && !isOnePanelOpen)
            GoToLobbyPanelOpen();
    }

    public void settingsPanelOpen()
    {
        if (!isOnePanelOpen)
        {
            isOnePanelOpen = true;
            settingsPanel.SetActive(true);
        }
    }

    public void ExitPanelOpen()
    {
        if (!isOnePanelOpen)
        {
            isOnePanelOpen = true;
            exitPanel.SetActive(true);
        }
    }

    public void GoToLobbyPanelOpen()
    {
        if (!isOnePanelOpen)
        {
            isOnePanelOpen = true;
            goToLobbyPanel.SetActive(true);
        }
    }
    public void AllPanelClose()
    {
        isOnePanelOpen = false;

        
        settingsPanel.SetActive(false);
        exitPanel.SetActive(false);
        goToLobbyPanel.SetActive(false);
    }

    public void GameQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void GoToLobbyYes()
    {
        SceneChanger.instance.ChangeScene("LobbyScene");
    }
}
