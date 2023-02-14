using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene(0);
    }
}
