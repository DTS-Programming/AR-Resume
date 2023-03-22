using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}
