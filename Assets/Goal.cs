using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public TimeManager TM;
    public int NextLevel;
    public float TimeUntilNextLevel;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player" || collision.tag == "Player_1"){
            TM.StopAndSaveScore();
            StartCoroutine(WaitAndChanceLevel());
        }
    }
    IEnumerator WaitAndChanceLevel(){
        yield return new WaitForSeconds(TimeUntilNextLevel);
        SceneManager.LoadScene(NextLevel);
    }
}
