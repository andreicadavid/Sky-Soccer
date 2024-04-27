using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finishline : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Finish();
    }

    void Finish()
    {
        SceneManager.LoadScene("FinishMenu");
    }
}
