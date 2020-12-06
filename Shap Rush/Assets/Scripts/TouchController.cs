using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class TouchController : MonoBehaviour { 


    Vector2 startPosition;
    Vector2 endPosition;
    bool directionChosen;
    Vector2 currentSwipe;
    Vector2 Distance;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //print("Touches: " + Input.touchCount);
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPosition = touch.position;
                    directionChosen = false;
                    break;
                case TouchPhase.Moved:
                    break;

                case TouchPhase.Ended:
                    endPosition = touch.position;
                    print("Star: " + startPosition + "End: " + endPosition + "Distance: " + (endPosition - startPosition ));
                    directionChosen = true;
                    break;
                default:
                    directionChosen = false;
                    break;
            }
        }
    }

    void FixedUpdate()

    {
        
        Distance = endPosition - startPosition;

        Distance.Normalize();

        if (directionChosen) {
        if (Distance.y > 0 && Distance.x > -0.5f && Distance.x < 0.5f)
        {
            print("up swipe");
            directionChosen = false;

        }
        //swipe down
        else if (Distance.y < 0 && Distance.x > -0.5f && Distance.x < 0.5f)
        {
            print("down swipe");
            directionChosen = false;

        }
        //swipe left
        else if (Distance.x < 0 && Distance.y > -0.5f && Distance.y < 0.5f)
        {
            print("left swipe");
            directionChosen = false;
        }
        //swipe right
        else if (Distance.x > 0 && Distance.y > -0.5f && Distance.y < 0.5f)
        {
            print("right swipe");
            directionChosen = false;
            
        }

    }



        //if (directionChosen)
        //{
        //    if (Distance.y > 0.1)
        //    {
        //        print("Up");
        //        directionChosen = false;

        //    }
        //    else if (Distance.y < -0.1)
        //    {
        //        print("Down");
        //        directionChosen = false;

        //    }
        //    else if (Distance.x > 0.1 )
        //    {
        //        print("right");
        //        directionChosen = false;
        //    }
        //    else if( Distance.x < -0.1)
        //    {
        //        print("left");
        //        directionChosen = false;

        //    }




    }
        
}



