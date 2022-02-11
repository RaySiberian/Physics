using UnityEngine;

public class FirstTrap : MonoBehaviour
{
    [SerializeField] private GameObject toAppear;
    
    private void OnEnable()
    {
        toAppear.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        toAppear.SetActive(true);
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
