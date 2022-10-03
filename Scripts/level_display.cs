using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class level_display : MonoBehaviour
{
    public TMP_Text level_number;
    public LevelManager lvlManger;

    private void Update()
    {
        level_number.text = (lvlManger.getCurrLevel()).ToString();
    }

}
