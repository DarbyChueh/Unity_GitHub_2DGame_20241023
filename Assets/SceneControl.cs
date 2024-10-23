using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
  public void LoadScence(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
  public void QuitGame()
    {
        Application.Quit();
    }
}
