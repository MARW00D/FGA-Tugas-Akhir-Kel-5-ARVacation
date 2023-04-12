using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit_app : MonoBehaviour
{
   public void Quitapps()
   {
       Application.Quit();
       Debug.Log("sudah quit");
   }
}
