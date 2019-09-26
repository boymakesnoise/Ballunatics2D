using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPlay : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("Level");
    }
}
