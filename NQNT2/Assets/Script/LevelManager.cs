using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public Transform mainMenu, optionsMenu, settings;
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
            settings.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
            settings.gameObject.SetActive(false);
        }
    }
    public void SettingsMenu(bool clicked)
    {
        if (clicked == true)
        {
            settings.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(true);

        }
    }
}