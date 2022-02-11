using DG.Tweening;
using UnityEngine;

public class HummerTrap : MonoBehaviour
{
    [SerializeField] private Vector3 startRotation;
    [SerializeField] private Vector3 endRotation;
    [SerializeField] private float delayToStartAnimation;
    [SerializeField] private float duration;
    private BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        Sequence sequence = DOTween.Sequence();
        sequence.AppendInterval(delayToStartAnimation);
        sequence.Append(transform.DOLocalRotate(endRotation, duration).SetEase(Ease.OutQuart).OnComplete(() =>
        {
            boxCollider.enabled = true;
        }));
        sequence.Append(transform.DOLocalRotate(startRotation, duration).SetEase(Ease.OutQuart).OnComplete(() =>
        {
            boxCollider.enabled = true;
        }));
        sequence.SetLoops(-1);
    }
    //Система кукиш
    private void OnCollisionEnter(Collision collision)
    {
        boxCollider.enabled = false;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(-collision.contacts[0].normal * 25,ForceMode.Impulse);
    }
}
