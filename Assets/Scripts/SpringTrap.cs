using UnityEngine;

public class SpringTrap : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private bool isOnTrigger;
    private float time;
    void Update()
    {
        if (isOnTrigger)
        {
            time += Time.deltaTime;
            if (time > 2.5f)
            {
                GetComponent<MeshRenderer>().material.color = Color.green;
                player.transform.position = new Vector3(-5.5f, 0, 45f);
                Destroy(this);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isOnTrigger = true;
    }
}
