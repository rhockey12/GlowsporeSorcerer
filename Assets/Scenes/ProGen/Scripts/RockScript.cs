using UnityEngine;

public class RockScript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Hallway"))
        {
            // Destroy the rock if it collides with a hallway
            Destroy(gameObject);
        }
        
    }

}
