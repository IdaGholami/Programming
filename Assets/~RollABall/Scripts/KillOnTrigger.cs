using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace RollABall
{
    public class KillOnTrigger : MonoBehaviour
    {
        void OnParticleCollision()
        {
            // Get active scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the next scene up using buildIndex
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}