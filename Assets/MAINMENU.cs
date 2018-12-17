using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour {

	public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
