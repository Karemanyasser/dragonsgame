using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Method to be called when the Start button is clicked
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // Load the next scene
    }
}