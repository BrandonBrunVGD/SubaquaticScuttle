using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI shellsUI;
    [SerializeField] private TextMeshProUGUI gameOverShellsUI;
    [SerializeField] private TextMeshProUGUI gameOverHighestShellsUI;
    [SerializeField] private GameObject gameOverScreenUI;
    //[SerializeField] private GameObject winScreenUI;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private Image[] playerLives;
    GameManager gm;

    private void Start() {
        gm = GameManager.Instance;
        gameOverScreenUI.SetActive(false);
        //winScreenUI.SetActive(false);
        gm.onGameOver.AddListener(ActivateGameOverScreen);
        //gm.onGameWon.AddListener(ActivateWinScreen);
        gm.onDestroyLifeUI.AddListener(DestroyLife);
        gm.onAddLifeUI.AddListener(AddLife);
    }

    //GameOverScreen
    public void HandleConfirmButton() {
        gameOverScreenUI.SetActive(false);
        gm.currentShells = 0f;
        SceneManager.LoadScene("Menu");
    }

    private void ActivateGameOverScreen() {
        gameOverScreenUI.SetActive(true);
    }

    private void ActivateWinScreen() {
        //winScreenUI.SetActive(true);
    }

    private void OnGUI() {
        shellsUI.text = gm.GetShells();
        gameOverShellsUI.text = gm.GetShells();
        gameOverHighestShellsUI.text = gm.GetHighestShells();
    }

    public void DestroyLife() {
        playerLives[gm.playerLives - 1].enabled = false;
    }

    private void AddLife() {
        playerLives[gm.playerLives - 1].enabled = true;
        Debug.Log("Life Added");
    }
}
