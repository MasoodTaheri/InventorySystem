using System;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    [SerializeField] protected CanvasGroup canvasGroup;
    private float _targetAlpha;
    private float _fadeSpeed = 3;
    protected virtual void Awake()
    {
        if (canvasGroup == null)
            canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
        // canvasGroup.alpha = 1;
        _targetAlpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    public virtual void Hide()
    {
        //canvasGroup.alpha = 0;
        _targetAlpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        //gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_targetAlpha != canvasGroup.alpha)
        {
            if (_targetAlpha == 0)
            {
                canvasGroup.alpha -= Time.deltaTime * _fadeSpeed;
                if (_targetAlpha > canvasGroup.alpha)
                {
                    canvasGroup.alpha = _targetAlpha;
                    gameObject.SetActive(false);
                }

            }

            if (_targetAlpha == 1)
            {
                canvasGroup.alpha += Time.deltaTime * _fadeSpeed;
                if (_targetAlpha < canvasGroup.alpha)
                {
                    canvasGroup.alpha = _targetAlpha;
                }
            }
        }
    }


}
