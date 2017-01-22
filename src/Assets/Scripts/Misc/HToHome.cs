using UnityEngine;
using UnityEngine.SceneManagement;

public class HToHome : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            SceneManager.LoadScene(0);
    }
}
