using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCooldown : MonoBehaviour
{
    [SerializeField] private float cooldownInSeconds;
    [SerializeField] private KeyCode keyCode;
    private float timeUntilSpawn = 1;
    private bool coolingDown = false;
    
    private void Update() {
        if (GameManager.Instance.isPlaying) {
            if (coolingDown == false) {
                if (Input.GetKeyDown(keyCode)) {
                    coolingDown = true;
                    timeUntilSpawn = 1;
                    DoAbility();
                }
            }
            else if (coolingDown) {
                CoolDown();
            }
        }
    }

    private void CoolDown() {
        timeUntilSpawn -= 1 / cooldownInSeconds * Time.deltaTime;

        if (timeUntilSpawn <= 0) {
            coolingDown = false;     
        }
    }

    private void DoAbility() {
        if (keyCode == KeyCode.Space) {
            gameObject.GetComponent<PlayerMovement>().SpawnBullet();
        }
    }
}
