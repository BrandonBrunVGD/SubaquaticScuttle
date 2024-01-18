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
    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    #endregion

    public bool isPlaying = false;
    public float currentShells = 0f;
    public float highestShells = 0f;
    private void Update() {
        if (isPlaying) {

        }

    
    }

    public void StartGame() {
        onPlay.Invoke();
        isPlaying = true;
    }

    public void GameOver() {
        onGameOver.Invoke();
        isPlaying = false;

        if (currentShells > highestShells) {
            highestShells = currentShells;
        }
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
}
