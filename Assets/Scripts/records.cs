using UnityEngine;

public class Records : MonoBehaviour
{

    public static Records Instance { get; private set; }

    public float[] records = { 99999f, 99999f};
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
       
