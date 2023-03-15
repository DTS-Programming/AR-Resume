using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}
