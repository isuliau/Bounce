using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    [SerializeField] GameObject Darkner;
    [SerializeField] GameObject levelselect;
    [SerializeField] LevelSelect Level2;
    [SerializeField] LevelSelect Level3;
    [SerializeField] LevelSelect Level4;
    [SerializeField] LevelSelect Level5;
    [SerializeField] GameObject GoldMedal1;
    [SerializeField] GameObject GoldMedal2;

    [SerializeField] GameObject GoldMedal3;

    [SerializeField] GameObject GoldMedal4;
   [SerializeField] GameObject GoldMedal5;
    [SerializeField] GameObject SilverMedal1;
    [SerializeField] GameObject SilverMedal2;
    [SerializeField] GameObject SilverMedal3;
    [SerializeField] GameObject SilverMedal4;
    [SerializeField] GameObject SilverMedal5;
    [SerializeField] GameObject BronzeMedal1;
    [SerializeField] GameObject BronzeMedal2;
    [SerializeField] GameObject BronzeMedal3;
    [SerializeField] GameObject BronzeMedal4;
    [SerializeField] GameObject BronzeMedal5;

    

    public void Begin(){ 
    Darkner.SetActive(true);
    levelselect.SetActive(true);
    if(Records.Instance.beat[1]) Level2.gameObject.SetActive(true);
    if(Records.Instance.beat[2]) Level3.gameObject.SetActive(true);
    if(Records.Instance.beat[3]) Level4.gameObject.SetActive(true);
    if(Records.Instance.beat[4]) Level5.gameObject.SetActive(true);
    if(Records.Instance.medalsGold[0] > Records.Instance.records[0]) GoldMedal1.SetActive(true);
    if(Records.Instance.medalsSilver[0] > Records.Instance.records[0]) SilverMedal1.SetActive(true);
    if(Records.Instance.medalsBronze[0] > Records.Instance.records[0]) BronzeMedal1.SetActive(true);
    if(Records.Instance.medalsGold[1] > Records.Instance.records[1]) GoldMedal2.SetActive(true);
    if(Records.Instance.medalsSilver[1] > Records.Instance.records[1]) SilverMedal2.SetActive(true);
    if(Records.Instance.medalsBronze[1] > Records.Instance.records[1]) BronzeMedal2.SetActive(true);
    if(Records.Instance.medalsGold[2] > Records.Instance.records[2]) GoldMedal3.SetActive(true);
    if(Records.Instance.medalsSilver[2] > Records.Instance.records[2]) SilverMedal3.SetActive(true);
    if(Records.Instance.medalsBronze[2] > Records.Instance.records[2]) BronzeMedal3.SetActive(true);
    if(Records.Instance.medalsGold[3] > Records.Instance.records[3]) GoldMedal4.SetActive(true);
    if(Records.Instance.medalsSilver[3] > Records.Instance.records[3]) SilverMedal4.SetActive(true);
    if(Records.Instance.medalsBronze[3] > Records.Instance.records[3]) BronzeMedal4.SetActive(true);
    if(Records.Instance.medalsGold[4] > Records.Instance.records[4]) GoldMedal5.SetActive(true);
    if(Records.Instance.medalsSilver[4] > Records.Instance.records[4]) SilverMedal5.SetActive(true);
    if(Records.Instance.medalsBronze[4] > Records.Instance.records[4]) BronzeMedal5.SetActive(true);
}
}
