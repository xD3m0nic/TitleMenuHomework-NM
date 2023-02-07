using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool paused;
    public GameObject Pausemenu;


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetPauseMenu(bool IsPaused)
    {
        paused = IsPaused;
        Time.timeScale = (paused) ? 0 : 1;
        Pausemenu.SetActive(paused);
    }
    // Start is called before the first frame update
    void Start()
    {
        paused = false;

        SetPauseMenu(false);
    }

    public void MainMen()
    {
        SceneManager.LoadScene(1);
    }


}
