using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    private int MENU_SCENE = 0;
    private int GAME_SCENE = 1;
    private int END_GAME_SCENE = 2;
    private int WIN_GAME_SCENE = 3;

    public void goToMenu(){
        SceneManager.LoadScene(MENU_SCENE);
    }

    public void goToEndGame(){
        SceneManager.LoadScene(END_GAME_SCENE);
    }

    public void goToWinGame(){
        SceneManager.LoadScene(WIN_GAME_SCENE);
    }

    public void goToGame(){
        SceneManager.LoadScene(GAME_SCENE);
    }

}
