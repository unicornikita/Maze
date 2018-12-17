using UnityEngine;
using UnityEngine.UI;

public class GameTimerScript : MonoBehaviour {
        public Text gameTimerText;
        float gameTimer=0f;
        
    
	
	// Update is called once per frame
	void Update () {
        gameTimer += Time.deltaTime;
        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        gameTimerText.text = timerString;
	}
}
