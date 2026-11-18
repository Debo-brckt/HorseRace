using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // ceci se déclanche peut importe ce qu'il se passe, donc peut importe qui ou quoi rentre dans la zone
    private void OnTriggerEnter(Collider collider)
    {
        [SerialiseField] private GameManagerScript;

        // on precise qui rentre pour que ça s'active
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Le jouer a atteint la ligne d'arriver");
            gameManagerScript.ComploeteLevel();
        }
    }
}
