using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaElJuego : MonoBehaviour
{
   public void EscenaJuego()
    {
        SceneManager.LoadScene("level1");
    }
}
