using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    [SerializeField]
    float delay = 1.5f;
    void Start()
    {
        StartCoroutine(_LoadFirstScene());
    }

    IEnumerator _LoadFirstScene()
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
