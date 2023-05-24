using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_click_to_animate : MonoBehaviour
{
    Animator  m_animator;
    void Start()
    {
        m_animator = transform.GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        m_animator.SetTrigger("hit");
    }
}
