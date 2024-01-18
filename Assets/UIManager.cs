using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI shellsUI;
    [SerializeField] private TextMeshProUGUI gameOverShellsUI;
    [SerializeField] private TextMeshProUGUI gameOverHighestShellsUI;
    [SerializeField] private GameObject startScreenUI;
    [SerializeField] private GameObject gameOverScreenUI;
    GameManager gm;

    private void Start() {
        gm = GameManager.Instance;
        gameOverScreenUI.SetActive(false);
        gm.onGameOver.AddListener(ActivateGameOverScreen);
    }

    //StartMenuScreen
    public void HandleStartButton() {
        gm.StartGame();
        startScreenUI.SetActive(false);
    }

    //GameOverScreen
    public void HandleConfirmButton() {
        gameOverScreenUI.SetActive(false);
        startScreenUI.SetActive(true);
        gm.currentShells = 0f;
    }

    public void ActivateGameOverScreen() {
        gameOverScreenUI.SetActive(true);
    }

    private void OnGUI() {
        shellsUI.text = gm.GetShells();
        gameOverShellsUI.text = gm.GetShells();
        gameOverHighestShellsUI.text = gm.GetHighestShells();
    }
}
