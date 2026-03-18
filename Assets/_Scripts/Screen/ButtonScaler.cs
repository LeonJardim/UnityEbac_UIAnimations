using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Animation")]
    [SerializeField] private float _finalScale = 1.2f;
    [SerializeField] private float _scaleDuration = 0.1f;

    private Vector3 _defaultScale;


    private void Awake()
    {
        _defaultScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        DOTween.Kill(transform, true);
        transform.DOScale(_finalScale * _defaultScale, _scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DOTween.Kill(transform, true);
        transform.DOScale(_defaultScale, _scaleDuration);
    }
}
