using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManger;
    void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}
