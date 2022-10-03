using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public static int currlevelNumeber = 1;

    //private void Start()
    //{
        //currlevelNumeber = 1;
    //}

    public void update_level()
    {
        currlevelNumeber++;
    }

    public static void update_level(int x)
    {
        currlevelNumeber = x;
    }

    public int getCurrLevel()
    {
        return currlevelNumeber;
    }


}
