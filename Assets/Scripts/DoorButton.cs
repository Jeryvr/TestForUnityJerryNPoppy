using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [Header("Made By P1_vr")]

    [Header("DoorButtonsManager Script")]
    public DoorButtonsManager manager;
    [Header("Tag")]
    public string handTag;
    [Header("Pressed Material")]
    public Material pressedMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(handTag))
        {
            foreach (var button in manager.buttons)
            {
                if (button.buttonScript == this && !button.isPressed)
                {
                    button.isPressed = true;
                    ChangeMaterial();
                    manager.CheckAllButtons();
                    break;
                }
            }
        }
    }

    private void ChangeMaterial()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && pressedMaterial != null)
        {
            renderer.material = pressedMaterial;
        }
    }
}
