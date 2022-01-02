using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonIndex : MonoBehaviour
{
    public static int index { get; private set; } // ENCAPSULATION
    public int m_input;

    private void Start()
    {
        
    }

    public void StartGame()
    {
        MainManager.instance.vehicleIndex = m_input;
        SceneManager.LoadScene(1);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
