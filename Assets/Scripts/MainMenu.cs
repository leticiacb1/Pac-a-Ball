using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Próxima cena precisa ser o jogo 
    }

    public void QuitGame () {
        Debug.Log("QUIT !");
        Application.Quit();
    }
}
