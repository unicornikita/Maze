using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour {

    public float RestartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Restart", RestartDelay);   
        }

    }
}
