using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayer : MonoBehaviour
{
   private void Start() {
    GameManager.Instance.onPlay.AddListener(ActivatePlayer); 
    
   }

   private void ActivatePlayer() {
        gameObject.SetActive(true);
   }
}
