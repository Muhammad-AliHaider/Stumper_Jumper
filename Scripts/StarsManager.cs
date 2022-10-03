using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class StarsManager : MonoBehaviour
{
    [SerializeField] private GameObject star1;
    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;
    public TimerScript timerScript;
    public LevelManager levelManager;
    private string[] saveStars;

    private float three, two, one = 0; 

    private void Update()
    {
        if (timerScript.win[levelManager.getCurrLevel() - 1].getWin() == true)
        {
            switch (levelManager.getCurrLevel())
            { 
                case 1:
                    three = 10.00f;
                    two = 15.00f;
                    one = 20.00f;
                    break;

                case 2:
                    three = 7.00f;
                    two = 13.00f;
                    one = 15.00f;
                    break;

                case 3:
                    three = 13.00f;
                    two = 18.00f;
                    one = 22.00f;
                    break;

                case 4:
                    three = 7.00f;
                    two = 13.00f;
                    one = 15.00f;
                    break;

                case 5:
                    three = 10.00f;
                    two = 15.00f;
                    one = 18.00f;
                    break;

                case 6:
                    three = 10.00f;
                    two = 15.00f;
                    one = 20.00f;
                    break;

                case 7:
                    three = 7.00f;
                    two = 13.00f;
                    one = 15.00f;
                    break;

                case 8:
                    three = 15.00f;
                    two = 20.00f;
                    one = 23.00f;
                    break;

                case 9:
                    three = 15.00f;
                    two = 20.00f;
                    one = 25.00f;
                    break;

                case 10:
                    three = 12.00f;
                    two = 15.00f;
                    one = 20.00f;
                    break;

                case 11:
                    three = 17.00f;
                    two = 22.00f;
                    one = 25.00f;
                    break;

                case 12:
                    three = 18.00f;
                    two = 22.00f;
                    one = 27.00f;
                    break;

                case 13:
                    three = 18.00f;
                    two = 22.00f;
                    one = 27.00f;
                    break;

                case 14:
                    three = 15.00f;
                    two = 18.00f;
                    one = 22.00f;
                    break;

                case 15:
                    three = 16.00f;
                    two = 20.00f;
                    one = 25.00f;
                    break;
            }
                
            if (timerScript.getTime() <= three)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);

            }
            else if (timerScript.getTime() <= two)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);

            }
            else if (timerScript.getTime() <= one)
            {
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(false);

            }
            else
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            
        }
    }

    



}
