using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName) {
        Debug.Log("Level load requested for:" + levelName);
    }

    public void QuitRequest() {
        Debug.Log("Quiting");
    }
}
