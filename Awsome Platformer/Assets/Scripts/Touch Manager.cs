using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour
{
    public static bool guiTouch = false;
    
    public void TouchInput(GUITexture texture)
    {
        if (texture.HitTest(Input.GetTouch(0).position))
        {
            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnFirstTouchBegan");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnFirstTouchMoved");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnFirstTouchStayed");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Ended:
                    SendMessage("OnFirstTouchEnded");
                    guiTouch = true;
                    break;
            }

        }
        if (texture.HitTest(Input.GetTouch(0).position))
        {
            switch (Input.GetTouch(1).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnSecondTouchBegan");
                    SendMessage("OnSecondTouch");
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnSecondTouchMoved");
                    SendMessage("OnSecondTouch");
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnSecondTouchStayed");
                    SendMessage("OnSecondTouch");
                    break;
                case TouchPhase.Ended:
                    SendMessage("OnSecondTouchEnded");
                    break;
            }

        }
    }
}


