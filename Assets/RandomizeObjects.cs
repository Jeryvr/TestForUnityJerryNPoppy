using UnityEngine;

public class RandomActiveCollider : MonoBehaviour
{
    [Tooltip("Assign the objects that each have a collider here.")]
    public GameObject[] objectsWithColliders;

    private void Start()
    {
        if (objectsWithColliders == null || objectsWithColliders.Length == 0)
        {
            Debug.LogError("No objects assigned in RandomActiveCollider script.");
            return;
        }

        // Pick one random index
        int randomIndex = Random.Range(0, objectsWithColliders.Length);

        for (int i = 0; i < objectsWithColliders.Length; i++)
        {
            Collider col = objectsWithColliders[i].GetComponent<Collider>();

            if (col == null)
            {
                Debug.LogWarning(objectsWithColliders[i].name + " has no collider component.");
                continue;
            }

            col.enabled = (i == randomIndex); // Enable only one
        }
    }
}
