using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region Singleton
    

    public static GameManager Instance;
    public UnityEvent onPlay = new UnityEvent();
    public UnityEvent onGameOver = new UnityEvent();
    public UnityEvent onGameWon = new UnityEvent();
    public UnityEvent onDestroyLifeUI = new UnityEvent();
    public UnityEvent onAddLifeUI = new UnityEvent();
    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    #endregion

    public AudioManager am;
    public bool isPlaying = false;
    public float currentShells = 0f;
    public float highestShells = 0f;
    public int playerLives = 3;

    //Wave info
    public int jelliesKilled = 0;
    public int eelsKilled = 0;
    public int puffersKilled = 0;
    public int currentWave = -1;

    private void Start() {
        am = AudioManager.Instance;
        onPlay.Invoke();
        isPlaying = true;
    }
    private void Update() {
        if (isPlaying) {
            Debug.Log(playerLives);
        }
    }

    public void StartGame() {
        
    }

    public void GameOver() {
        onGameOver.Invoke();
        isPlaying = false;

        if (currentShells > highestShells) {
            highestShells = currentShells;
        }
    }

    public void GameWon() {
        onGameWon.Invoke();
        isPlaying = false;
    }

    public string GetShells() {
        return currentShells.ToString();
    }

    public string GetHighestShells() {
        return highestShells.ToString();
    }

    public void AddShells(float shells) {
        currentShells += shells;
    }

    public void DestroyLifeUI() {
        onDestroyLifeUI.Invoke();
    }

    public void AddLifeUI() { 
        if (playerLives < 3) {
            playerLives += 1;
        }
        onAddLifeUI.Invoke();
    }

    public int GetCurrentWave() {
        return currentWave;
    }

    public void AddCurrentWave() {
        currentWave += 1;
    }
}
