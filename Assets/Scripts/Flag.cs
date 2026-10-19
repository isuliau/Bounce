using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;
public class Flag : MonoBehaviour
{
    [SerializeField] private TMP_Text time;
    [SerializeField] private Timer timer;
        [SerializeField] GameObject panel;
[SerializeField] private GameObject darkenpanel;
[SerializeField] private int currentlevelminus1;
[SerializeField] private GameObject GoldMedal;
[SerializeField] private GameObject SilverMedal;
[SerializeField] private GameObject BronzeMedal;
private bool fast = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Records.Instance.beat[currentlevelminus1+1] = true;
        
        if(timer.time < Records.Instance.records[currentlevelminus1]){ Records.Instance.records[currentlevelminus1] = timer.time; fast = true;}
        panel.SetActive(true);
        time.text = "At a time of: " + timer.time.ToString("F3") + "<br> The current record is " + Records.Instance.records[currentlevelminus1].ToString("F3") + " seconds";
        if(fast) time.text = "At a time of: " + timer.time.ToString("F3") + "<br> NEW RECORD OF " + Records.Instance.records[currentlevelminus1].ToString("F3") + " SECONDS";
    darkenpanel.SetActive(false);
    if(Records.Instance.medalsGold[currentlevelminus1] > Records.Instance.records[currentlevelminus1]) GoldMedal.SetActive(true);
        if(Records.Instance.medalsSilver[currentlevelminus1] > Records.Instance.records[currentlevelminus1]) SilverMedal.SetActive(true);
        if(Records.Instance.medalsBronze[currentlevelminus1] > Records.Instance.records[currentlevelminus1]) BronzeMedal.SetActive(true);
        Time.timeScale = 0f;
        fast = false;
    }
    
}
