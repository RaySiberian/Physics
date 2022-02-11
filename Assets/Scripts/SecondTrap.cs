using DG.Tweening;
using UnityEngine;

public class SecondTrap : MonoBehaviour
{
    private Sequence sequence;
    private Vector3 startPosition;
    private Vector3 endPosition;
    
    private void Start()
    {
        startPosition = transform.position;
        endPosition = transform.position + new Vector3(10, 0, 0);
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOLocalMove(endPosition, 3));
        sequence.Append(transform.DOLocalMove(startPosition, 3));
        sequence.SetLoops(-1);
    }
}
