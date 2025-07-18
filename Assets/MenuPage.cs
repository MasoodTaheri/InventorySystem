using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPage : MonoBehaviour
{
    [SerializeField] private List<UIAnimator> animators = new List<UIAnimator>();

    public void Show()
    {
        gameObject.SetActive(true);
        foreach (UIAnimator animator in animators)
        {
            animator.PlayForward();
        }
    }

    public void Hide()
    {
        foreach (UIAnimator animator in animators)
        {
            animator.PlayBackward();
        }
    }
}
