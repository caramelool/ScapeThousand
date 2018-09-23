using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts {
    public class Stage
    {
        public static int Get()
        {
            return PlayerPrefs.GetInt("PLAYER_STAGE");
        }

        public static void Set(int stage)
        {
            PlayerPrefs.SetInt("PLAYER_STAGE", stage);
            PlayerPrefs.Save();
        }

        public static void New()
        {
            int stage = Get() + 1;
            Set(stage);
            Load(stage);
        }

        public static void Load(int stage) {
            SceneManager.LoadScene(stage % 3);
        }
    }    
}