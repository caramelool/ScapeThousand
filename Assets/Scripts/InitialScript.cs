﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scripts;

public class InitialScript : MonoBehaviour {
    
	void Start () {
        int stage = Stage.Get();
        if (stage <= 0) {
            Stage.New();
		} else {
            Stage.Load(stage);    
        }
	}
}
