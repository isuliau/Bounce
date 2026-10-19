using UnityEngine;

public class Records : MonoBehaviour
{

    public static Records Instance { get; private set; }

    public float[] records = {99999f, 99999f, 99999f, 99999f, 99999f, 99999f, 99999f, 99999f, 99999f};
    public float[] medalsGold = {10f, 15f, 17f, 21f, 28f, 99999f, 99999f, 99999f, 99999f};
    public float[] medalsSilver = {15f, 20f, 23f, 29f, 40f, 99999f, 99999f, 99999f, 99999f};
    public float[] medalsBronze = {20f, 30f, 30f, 40f, 60f, 99999f, 99999f, 99999f, 99999f};
    public bool[] beat = {true, false, false, false, false, false, false, false, false, false, false};
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
       
