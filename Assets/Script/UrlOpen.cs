using UnityEngine;

public class UrlOpen : MonoBehaviour
{
    public string LinkInternet;

    public void Open()
    {
        Application.OpenURL(LinkInternet);
        Debug.Log("Kondisi Sudah Open Website");
    }
}
