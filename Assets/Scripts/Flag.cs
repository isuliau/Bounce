using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;
public class Flag : MonoBehaviour
{
    [SerializeField] private TMP_Text time;
    [SerializeField] private Timer timer;
        [SerializeField] GameObject panel;
[SerializeField] private GameObject darkenpanel;

float y;
[SerializeField] private int currentlevelminus1;
private bool fast = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(timer.time < Records.Instance.records[currentlevelminus1]){ Records.Instance.records[currentlevelminus1] = timer.time; fast = true;}
        panel.SetActive(true);
        time.text = "At a time of: " + timer.time.ToString("F3") + "<br> The current record is " + Records.Instance.records[currentlevelminus1].ToString("F3") + " seconds";
        if(fast) time.text = "At a time of: " + timer.time.ToString("F3") + "<br> NEW RECORD OF " + Records.Instance.records[currentlevelminus1].ToString("F3") + " SECONDS";
    darkenpanel.SetActive(false);
        Time.timeScale = 0f;
        fast = false;
    }
    
}
