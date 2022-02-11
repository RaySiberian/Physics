using DG.Tweening;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Sequence sequence;
    private Vector3 startPosition;
    private Vector3 endPosition;
    void Start()
    {
        startPosition = transform.position;
        endPosition = transform.position + new Vector3(0, 10, 0);
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOLocalMove(endPosition, 5));
        sequence.Append(transform.DOLocalMove(startPosition, 5));
        sequence.SetLoops(-1);
    }
}
