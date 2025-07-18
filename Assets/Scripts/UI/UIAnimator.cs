using UnityEngine;
using DG.Tweening;

namespace Assets.Scripts.UI
{
    public class UIAnimator : MonoBehaviour
    {
        [Header("Positions")]
        [SerializeField] private RectTransform _targetObject;
        [SerializeField] private Vector2 _startPosition;
        [SerializeField] private Vector2 _endPosition;

        [Header("Scale")]
        [SerializeField] private Vector2 _startScale = Vector2.zero;
        [SerializeField] private Vector2 _endScale = Vector2.one;

        [Header("Animation Settings")]
        [SerializeField] private float _moveDuration = 0.5f;
        [SerializeField] private Ease _moveEase = Ease.OutBack;
        [SerializeField] private float _scaleDuration = 0.3f;
        [SerializeField] private Ease _scaleEase = Ease.OutQuad;

        private Tween _moveTween;
        private Tween _scaleTween;


        void Awake()
        {
            // Initialize at start position
            if (_targetObject != null)
            {
                _targetObject.anchoredPosition = _startPosition;
                _targetObject.localScale = _startScale;
            }
        }

        [ContextMenu("Play Forward")]
        public void PlayForward()
        {
            PlayAnimation(_endPosition, _endScale);
        }

        [ContextMenu("Play Backward")]
        public void PlayBackward()
        {
            PlayAnimation(_startPosition, _startScale);
        }

        private void PlayAnimation(Vector2 targetPos, Vector2 targetScale)
        {
            // Kill existing tweens to prevent conflicts
            _moveTween?.Kill();
            _scaleTween?.Kill();

            // Move animation
            _moveTween = _targetObject.DOAnchorPos(targetPos, _moveDuration)
                .SetEase(_moveEase);

            // Scale animation
            _scaleTween = _targetObject.DOScale(targetScale, _scaleDuration)
                .SetEase(_scaleEase);
        }

        // Editor helper to set current position as start/end
        [ContextMenu("Set As Start Position")]
        private void SetAsStartPosition()
        {
            if (_targetObject != null)
            {
                _startPosition = _targetObject.anchoredPosition;
                _startScale = _targetObject.localScale;
            }
        }

        [ContextMenu("Set As End Position")]
        private void SetAsEndPosition()
        {
            if (_targetObject != null)
            {
                _endPosition = _targetObject.anchoredPosition;
                _endScale = _targetObject.localScale;
            }
        }
    }
}