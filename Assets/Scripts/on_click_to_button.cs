using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class on_click_to_button : MonoBehaviour
{
    [SerializeField] GameObject m_button;
    void OnMouseDown()
    {
        m_button.SetActive(true);
        transform.gameObject.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(0);
    }
}
