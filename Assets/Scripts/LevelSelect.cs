using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
public void Level(int index){
     SceneManager.LoadScene(index);
}
}
