using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost_1 : MonoBehaviour
{
    public float SpeedDuration = 3;
    public float SpeedPowerAmount = 800;

    private void OnTriggerEnter2D(Collider2D collision){
    if (collision.tag == "Player_1"){
        collision.GetComponent<Player_movement>().SpeedPowerUp(SpeedDuration, SpeedPowerAmount);
        Destroy(gameObject);
        }
    }
}