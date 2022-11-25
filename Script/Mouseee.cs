using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouseee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
     public void QuitGame()
    {
        SceneManager.LoadScene(2);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
