using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private LayerMask playerObject;
    private bool m_Highlighted;

    private BoxCollider2D m_BoxCollider;
    private bool m_openScene;

    [Header("EVents")]
    [Space]
    public UnityEvent OnHightLightEvent;
    public UnityEvent OffHightLightEvent;
    public UnityEvent OnAnotherSceneOpenEvent;

    // Start is called before the first frame update
    private void Awake()
    {
        m_BoxCollider = GetComponent<BoxCollider2D>();

        if (OnHightLightEvent == null)
            OnHightLightEvent = new UnityEvent();
        if (OffHightLightEvent == null)
            OffHightLightEvent = new UnityEvent();
        if (OnAnotherSceneOpenEvent == null)
            OnAnotherSceneOpenEvent = new UnityEvent();
    }

    private void FixedUpdate()
    {
        if(m_openScene && Input.GetButtonDown("Open"))
        {
            OnAnotherSceneOpenEvent.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnHightLightEvent.Invoke();
        m_openScene = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        OffHightLightEvent.Invoke();
        m_openScene = false;
    }
}
