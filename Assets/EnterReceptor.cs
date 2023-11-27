using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterReceptor : MonoBehaviour
{
    public UnityEvent TotemEnter;


    // Cette fonction est appelée lorsque quelque chose entre dans le collider du recepteur
    private void OnTriggerEnter(Collider other)
    {
        // Vérifiez si l'objet a le tag "Totem_room1"
        if (other.CompareTag("Totem_room1"))
        {
            TotemEnter.Invoke();
        }
    }
}
