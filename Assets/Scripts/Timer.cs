using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text label;
    public float time = 0f;


    void Update()
    {
        
        time += Time.deltaTime;
        label.text = time.ToString("F3");
    }
}