using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    public void LoadLevel() {
        SceneManager.LoadScene("SampleScene");
    }

    void Update() {
        if(Input.GetKeyDown("return")) {
             SceneManager.LoadScene("SampleScene");
        }
    }
}
