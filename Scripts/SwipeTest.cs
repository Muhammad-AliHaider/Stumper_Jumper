using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour
{
    [SerializeField] private touchcontrols swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    private bool stopMoving = false;
    private bool right, left, up, down = false;
    private Vector3 initPosition;
    private bool enable_moving = true;

    private void Update()
    { 
        if (swipeControls.SwipeLeft && enable_moving)
        {
            initPosition = player.position;
            desiredPosition += Vector3.left * 500f;
            up = down = right = false;
            left = true;
            enable_moving = false;
        }
        else if (swipeControls.SwipeRight && enable_moving)
        {
            initPosition = player.position;
            up = down = left = false;
            right = true;
            desiredPosition += Vector3.right * 500f;
            enable_moving = false;
        }
        else if (swipeControls.SwipeUp && enable_moving)
        {
            initPosition = player.position;
            desiredPosition += Vector3.up * 500f;
            right = down = left = false;
            up = true;
            enable_moving = false;
        }
        else if (swipeControls.SwipeDown && enable_moving)
        {
            initPosition = player.position;
            right = up = left = false;
            down = true;
            desiredPosition += Vector3.down * 500f;
            enable_moving = false;
        }
    }

    private void FixedUpdate()
    {
        if (stopMoving == false)
        {
        player.localPosition = player.localPosition + desiredPosition * Time.deltaTime;
        }
        if(stopMoving == true)
        {
            stopMoving = false;
            enable_moving = true;

            desiredPosition = Vector3.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle_1")
        {
            //collision.gameObject.SetActive(false);

            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (collision.transform.tag == "checkup")
        {
            stopMoving = true;
            player.position = initPosition;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle_1")
        {
            stopMoving = true;


            for (int i = 0; i < 10; i++)
            {
                if (right)
                {
                    player.localPosition = player.localPosition + new Vector3(25.14f, 0, 0);
                    right = false;
                }

                else if (left)
                {
                    player.localPosition = player.localPosition + new Vector3(-25.14f, 0, 0);
                    left = false;
                }
                else if (down)
                {
                    player.localPosition = player.localPosition + new Vector3(0, -13.14f, 0);
                    down = false;
                }
                else if (up)
                {
                    player.localPosition = player.localPosition + new Vector3(0, 13.14f, 0);
                    up = false;
                }
            }
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
