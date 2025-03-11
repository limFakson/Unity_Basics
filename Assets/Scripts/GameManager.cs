using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnd = false;
    public float restartSpeed = 1.5f;

    public GameObject completeLevelUi;

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnd == false)
        {
            gameHasEnd = true;
            Debug.Log("Game Over");
            Invoke(nameof(Restart), restartSpeed);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
