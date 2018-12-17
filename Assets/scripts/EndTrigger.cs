using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public gamemanager gamemanager;

    private void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
