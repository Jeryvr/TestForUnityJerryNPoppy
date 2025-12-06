using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtonsManager : MonoBehaviour
{
    [System.Serializable]
    public class ButtonStuff
    {
        [Header("Button")]
        public DoorButton buttonScript;
        [Header("Is Button Pressed")]
        public bool isPressed = false;
    }

    [Header("Made By P1_vr")]

    [Header("Buttons")]
    public List<ButtonStuff> buttons = new List<ButtonStuff>();
    [Header("Objects To Enable Once All Buttons Pressed")]
    public List<GameObject> objectsToEnable;
    [Header("Objects To Disable Once All Buttons Pressed")]
    public List<GameObject> objectsToDisable;

    public void CheckAllButtons()
    {
        bool allPressed = true;
        foreach (var button in buttons)
        {
            if (!button.isPressed)
            {
                allPressed = false;
                break;
            }
        }

        if (allPressed)
        {
            foreach (var obj in objectsToEnable)
            {
                obj.SetActive(true);
            }

            foreach (var obj in objectsToDisable)
            {
                obj.SetActive(false);
            }
        }
    }
}
