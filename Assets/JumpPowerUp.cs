using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float JumpPowerDuration = 3;
    public float JumpPowerAmount = 800;

    private void OnTriggerEnter2D(Collider2D collision){
    if (collision.tag == "Player"){
        collision.GetComponent<Player_movement>().JumpPowerUp(JumpPowerDuration, JumpPowerAmount);
        Destroy(gameObject);
        }
    }
}
