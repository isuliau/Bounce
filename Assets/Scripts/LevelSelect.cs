using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
      int y;
 void Start()
    {
        y = SceneManager.GetActiveScene().buildIndex;
    }
   
     public void Level(int index){
     SceneManager.LoadScene(index);
}
public void goHome(){
     Time.timeScale = 1f;
     SceneManager.LoadScene(0);
     
}
public void Next(){
     Time.timeScale = 1f;
     SceneManager.LoadScene(y+1);
}


}
