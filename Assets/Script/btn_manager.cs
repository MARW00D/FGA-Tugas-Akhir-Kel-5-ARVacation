using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_manager : MonoBehaviour
{
   public void LoadScene(string Scenename)
   {
      SceneManager.LoadScene (Scenename);
   }
}
