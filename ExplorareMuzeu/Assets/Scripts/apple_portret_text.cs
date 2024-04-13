using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_portret_text : MonoBehaviour
{

    public Renderer objectRenderer;

    void Start()
    {
        // Verifică dacă obiectul renderer este valid
        if (objectRenderer != null)
        {
            // Dezactivează rendererul pentru a face obiectul invizibil
            objectRenderer.enabled = false;
        }
        else
        {
            // Dacă nu există renderer, afișează un mesaj de avertisment
            Debug.LogWarning("Renderer component not assigned!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifică dacă obiectul care a intrat în collider este jucătorul
        if (other.CompareTag("Player"))
        {
            // Activează rendererul pentru a face obiectul vizibil
            objectRenderer.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verifică dacă obiectul care a ieșit din collider este jucătorul
        if (other.CompareTag("Player"))
        {
            // Dezactivează rendererul pentru a face obiectul invizibil
            objectRenderer.enabled = false;
        }
    }
}
