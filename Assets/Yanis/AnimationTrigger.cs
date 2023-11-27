using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtrigger : MonoBehaviour
{

    public int objectsBeforeAnimation = 3;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on the object.");
        }
    }

    public void Decrease()
    {
        if (objectsBeforeAnimation > 0)
        {
            objectsBeforeAnimation--;
            CheckForAnimationTrigger();
        }
    }

    private void CheckForAnimationTrigger()
    {
        if (objectsBeforeAnimation == 0 && animator != null)
        {
            animator.SetTrigger("Open");
        }
    }
}