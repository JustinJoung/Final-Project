using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("LevelDesign");
    }
}