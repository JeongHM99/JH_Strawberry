using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
        SceneManager.LoadScene("TitleScene");
    }
}
