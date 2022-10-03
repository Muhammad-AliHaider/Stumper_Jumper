using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Level_select;
    [SerializeField] private GameObject Setting_on;
    [SerializeField] private GameObject Setting_off;
    [SerializeField] private GameObject Tutorial;
    private static bool enable_audio = true;
    [SerializeField] private GameObject square;
    public Sprite[] spriteArray;
    //[SerializeField] private GameObject lvl_1;

    private void Start()
    {
        Menu_page();
        
    }
    public void Level_Select()
    {
        Menu.SetActive(false);
        Level_select.SetActive(true);
        Setting_on.SetActive(false);
        Setting_off.SetActive(false);
        Tutorial.SetActive(false);
    }

    public void Settings_page()
    {
        Menu.SetActive(false);
        Level_select.SetActive(false);
        Tutorial.SetActive(false);
        if (enable_audio)
            Setting_on.SetActive(true);
        else
            Setting_off.SetActive(true);
    }

    public void Menu_page()
    {
        Menu.SetActive(true);
        Level_select.SetActive(false);
        Setting_on.SetActive(false);
        Setting_off.SetActive(false);
        Tutorial.SetActive(false);
    }

    public void play_button()
    {
        Menu.SetActive(false);
        Level_select.SetActive(false);
        Setting_on.SetActive(false);
        Setting_off.SetActive(false);
        Tutorial.SetActive(true);
    }
    public void play_button_tutorial()
    { 
        SceneManager.LoadScene("levels");
    }

    public void levelSelector(int x)
    {
        LevelManager.currlevelNumeber = x;
        Debug.LogError(x);
        SceneManager.LoadScene("levels");
    }

    public void audio_button()
    {
        enable_audio = !enable_audio;
        if (enable_audio)
        {
            Setting_on.SetActive(true);
            Setting_off.SetActive(false);
        }
        else
        {
            Setting_on.SetActive(false);
            Setting_off.SetActive(true);
        }
        square.GetComponent<AudioSource>().enabled = enable_audio;
    }

    public static bool get_audio()
    {
        return enable_audio;
    }

    public static void set_audio()
    {
        enable_audio = !enable_audio;
    }




}
