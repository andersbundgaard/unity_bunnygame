using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player" || collision.tag == "Player_1"){
            Destroy(collision.gameObject);
        }
    }

}
