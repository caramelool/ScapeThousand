using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts {
    public class Stage
    {
        private static int Get()
        {
            return PlayerPrefs.GetInt("PLAYER_STAGE");
        }

        public static void Save()
        {
            int stage = Get() + 1;
            PlayerPrefs.SetInt("PLAYER_STAGE", stage);
            PlayerPrefs.Save();
        }

        public static void Load() {
            int stage = Get();
            stage = (stage % 3) + 1;
            MonoBehaviour.print("Stage " + stage);
            SceneManager.LoadScene(stage);
        }
    }    
}