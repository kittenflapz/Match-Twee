using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupManager : MonoBehaviour
{
    public GameObject[] gameStuff;
    public GameObject[] startMenuStuff;
 

    [SerializeField]
    BoardManager boardManager;

    DifficultyLevel difficultyLevel = DifficultyLevel.EASY;

    public void SetDifficulty(int dropdownValue)
    {
        difficultyLevel = (DifficultyLevel)dropdownValue;
    }

    public void PopUpGame()
    {
        foreach (GameObject gameStuffObject in gameStuff)
        {
            gameStuffObject.SetActive(true);
        }
        foreach (GameObject startMenuStuffObject in startMenuStuff)
        {
            startMenuStuffObject.SetActive(false);
        }
        boardManager.InitializeGame(difficultyLevel);
    }


    public void PopDownGame()
    {
        foreach (GameObject gameStuffObject in gameStuff)
        {
            gameStuffObject.SetActive(false);
        }
        foreach (GameObject startMenuStuffObject in startMenuStuff)
        {
            startMenuStuffObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
