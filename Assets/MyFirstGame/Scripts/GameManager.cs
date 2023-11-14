using UnityEngine;
using UnityEngine.SceneManagement;

class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverObject;
    [SerializeField] string thisSceneName;
    [SerializeField] string nextSceneName;

    private void Start()
    {
        gameOverObject.SetActive(false);
    }

    public void OnGameEnded() 
    {
        // GAME OVER SCREEN ON
        gameOverObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(thisSceneName);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
