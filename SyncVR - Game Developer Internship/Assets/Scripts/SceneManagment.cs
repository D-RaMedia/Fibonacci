using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagment : MonoBehaviour
{
    public void ReloadScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
