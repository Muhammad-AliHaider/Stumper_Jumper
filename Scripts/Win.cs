using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    int le = 0;
    public static bool win = false;
    public LevelController lvl;
    //public GameObject lvl_won;
    //level and there obstacles
    const int l1 = 6;
    const int l2 = 8;
    const int l3 = 8;
    const int l4 = 6;
    const int l5 = 8;
    const int l6 = 7;
    const int l7 = 8;
    const int l8 = 8;
    const int l9 =11;
    const int l10 =11;
    const int l11 = 11;
    const int l12 = 10;
    const int l13 = 12;
    const int l14 = 12;
    const int l15 = 11;
    

    public void win_condition(int x)
    {
        switch (x)
        {
            case 1:
                le = l1;
                break;
            case 2:
                le = l2;
                break;

            case 3:
                le = l3;
                break;

            case 4:
                le = l4;
                break;

            case 5:
                le = l5;
                break;

            case 6:
                le = l6;
                break;

            case 7:
                le = l7;
                break;

            case 8:
                le = l8;
                break;

            case 9:
                le = l9;
                break;

            case 10:
                le = l10;
                break;

            case 11:
                le = l11;
                break;

            case 12:
                le = l12;
                break;

            case 13:
                le = l13;
                break;

            case 14:
                le = l14;
                break;

            case 15:
                le = l15;
                break;


        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle_1")
        {
            //level base switch
            //inside switch satement of each level 

            le--;
            Debug.LogError(lvl.levelManager.getCurrLevel());
            //Debug.LogError(le);
            if (le == 0)
            {
                Debug.LogError("Won");
                Debug.LogError(lvl.levelManager.getCurrLevel());
                //lvl.level_deactive();
                lvl.level_wonActive();
                
                //lvl.level_deactive();
                //Debug.Log("Won");
                win = true;
                //GameObject p = GameObject.Find("Level_1");
                //p.SetActive(false);
            }
        }
    }

    public bool getWin()
    {
        return win;
    }

    public void setWin(bool x)
    {
        win = x;
    }

    
}
