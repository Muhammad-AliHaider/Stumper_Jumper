using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_controller : MonoBehaviour
{
    [SerializeField] private GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(MenuController.get_audio());
        square.GetComponent<AudioSource>().enabled = MenuController.get_audio();
    }

    // Update is called once per frame
    
}
