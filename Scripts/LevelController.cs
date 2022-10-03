using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public LevelManager levelManager;
    public Win[] win;
    public TimerScript script;
    

    // gameObjects
    public GameObject[] lvls;

    //GameObject Lvl won
    public GameObject lvl_won;

    //public GameObject menu;
    public GameObject wining_prompt;

    private void Start()
    {
        level_deactive();
        level_active();
        activateObjects();
    }


    public void level_active()
    {
        win[levelManager.getCurrLevel() - 1].win_condition(levelManager.getCurrLevel());
        win[levelManager.getCurrLevel() - 1].setWin(false);
        lvls[levelManager.getCurrLevel() - 1].SetActive(true);
    }
    public void level_deactive()
    {
        foreach (GameObject go in lvls)
        {
            go.SetActive(false);
        }
    }

    public void onNextButton()
    {
        if (levelManager.getCurrLevel() < 15)
        {
            level_deactive();
            levelManager.update_level();
            level_active();
            activateObjects();
            lvl_won.SetActive(false);
            win[levelManager.getCurrLevel() - 1].win_condition(levelManager.getCurrLevel());
        }
        else
        {
            wining_prompt.SetActive(true);
            level_deactive();
            lvl_won.SetActive(false);
        }
    }

    public void restart()
    {
        
        level_active();
        activateObjects();
        
        lvl_won.SetActive(false);
        win[levelManager.getCurrLevel() - 1].win_condition(levelManager.getCurrLevel());
    }

    public void level_wonActive()
    {
        lvl_won.SetActive(true);
    }

    public void activateObjects()
    {
        script.resetTime();
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Obstacle_1");
        GameObject player = GameObject.FindGameObjectWithTag("Player");


        switch (levelManager.getCurrLevel())
        {
            case 1:
                player.transform.localPosition = new Vector3(-277f, -272f, 18872.27f);
                break;

            case 7:
                player.transform.localPosition = new Vector3(-281f, 210f, 18872.27f);
                break;

            case 8:
                player.transform.localPosition = new Vector3(-283f, -297f, 18872.27f);
                break;

            case 9:
                player.transform.localPosition = new Vector3(0f, 53f, 18872.27f);
                break;

            case 10:
                player.transform.localPosition = new Vector3(0f, 47f, 18872.27f);
                break;

            case 11:
                player.transform.localPosition = new Vector3(0f, 47f, 18872.27f);
                break;

            case 12:
                player.transform.localPosition = new Vector3(0f, -183f, 18872.27f);
                break;

            case 13:
                player.transform.localPosition = new Vector3(141f, 167f, 18872.27f);
                break;

            case 14:
                player.transform.localPosition = new Vector3(0f, 285f, 18872.27f);
                break;
            case 15:
                player.transform.localPosition = new Vector3(0f, -65f, 18872.27f);
                break;

            default:
                player.transform.localPosition = new Vector3(-283f, -255f, 18872.27f);
                break;
        } 
        
        
        foreach (GameObject go in gameObjects)
        {
            //Debug.LogError(go.tag);
            if (go.GetComponent<SpriteRenderer>().enabled== false)
            {
                //Debug.LogError("123");
                go.GetComponent<SpriteRenderer>().enabled = true;
                go.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                go.SetActive(true);
            }
        }
    }
    public void Menu_button()
    {
        SceneManager.LoadScene("menu");

    }

    /*public void lvl_selector(int x)
    {
        LevelManager.currlevelNumeber = x;
        level_deactive();
        restart();

    }*/

}
