using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void StartGame()
    {
        Load(1);
    }

    private void Load(int indexLevel)
    {
        SceneManager.LoadScene(indexLevel);
    }
}
