using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToStartScene() => SceneManager.LoadScene(0);
    public void GoToTypesScene() => SceneManager.LoadScene(1);
    public void GoToFirstProbScene() => SceneManager.LoadScene(2);
    public void GoToSecondProbScene() => SceneManager.LoadScene(3);
    public void GoToThirdProbScene() => SceneManager.LoadScene(4);
    public void GoToHistoryScene() => SceneManager.LoadScene(5);
}
