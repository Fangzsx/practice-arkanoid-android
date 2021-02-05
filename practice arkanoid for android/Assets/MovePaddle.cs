using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{

    //config params
    [SerializeField] float speed;

   
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //get touch position x
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            Debug.Log(touchPosition.x);
            Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
            

            if(paddlePos.x < touchPosition.x)
            {
                paddlePos.x++;
            }
            else
            {
                paddlePos.x--;
            }

            transform.position = Vector2.MoveTowards(transform.position, paddlePos, Time.deltaTime * speed);
            
        }
    }
}
