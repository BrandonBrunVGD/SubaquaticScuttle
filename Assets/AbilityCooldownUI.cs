using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCooldownUI : MonoBehaviour
{
   [SerializeField] private Image image;
   [SerializeField] private float cooldownInSeconds;
   [SerializeField] private KeyCode keyCode;
    
    private float timeUntilSpawn;
    private bool coolingDown = false;
    
    
    private void Update() {
        if (GameManager.Instance.isPlaying) {
            if (!coolingDown) {
                if (Input.GetKeyDown(keyCode)) {
                    image.fillAmount = 1;
                    coolingDown = true;
                }
            }
            else if (coolingDown) {
                CoolDown();
            }
        }
    }

    private void CoolDown() {
        image.fillAmount -= 1 / cooldownInSeconds * Time.deltaTime;

        if (image.fillAmount <= 0) {
            coolingDown = false;     
        }
    }
}
