using UnityEngine;

public class WinLoseTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private TriggerStatus triggerStatus;

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        if (triggerStatus == TriggerStatus.Win)
        {
            winPanel.SetActive(true);
        }
        else if (triggerStatus == TriggerStatus.Lose)
        {
            losePanel.SetActive(true);
        }
    }
    
    private enum TriggerStatus
    {
        Win,
        Lose
    }
}
