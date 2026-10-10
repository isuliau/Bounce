using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    [SerializeField] GameObject Darkner;
    [SerializeField] GameObject levelselect;
public void Begin(){ 
    Darkner.SetActive(true);
    levelselect.SetActive(true);
}
}
