using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI TextTid;
    public TextMeshProUGUI TextHighscore;
    private float _timeInLevel;
    private bool _runTimer = true;
    private string _CurrentLevelName;

    // Start is called before the first frame update
    void Start()
    {
        _CurrentLevelName = SceneManager.GetActiveScene().name;

        string score = "Highscore: "+PlayerPrefs.GetFloat(_CurrentLevelName).ToString("F1");
        TextHighscore.text = score;
    }

    // Update is called once per frame
    void Update()
    {
        if(_runTimer == true){
            _timeInLevel += Time.deltaTime;
        }
        TextTid.text = "Tid: "+_timeInLevel.ToString("F1");
    }

    public void StopAndSaveScore(){
        _runTimer = false;

        float lastScore = PlayerPrefs.GetFloat(_CurrentLevelName);
            if (lastScore > _timeInLevel || lastScore == 0){
                PlayerPrefs.SetFloat(_CurrentLevelName, _timeInLevel);
        }
    }
}
