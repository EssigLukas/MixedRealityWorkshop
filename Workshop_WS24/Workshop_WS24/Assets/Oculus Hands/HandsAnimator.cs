using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsAnimator : MonoBehaviour
{
    public Animator animator;
    public InputActionReference gripAction;
    public InputActionReference triggerAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var gripValue = gripAction.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);

        var triggerValue = triggerAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);
    }
}
