using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scripts;

public class FinishScript : MonoBehaviour {

    public Object scene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Stage.New();
        //SceneManager.LoadScene(scene.name);
    }
}
