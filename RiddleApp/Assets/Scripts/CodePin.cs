using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePin : MonoBehaviour
{
    public GameObject PinGame;
    public GameObject PhotosWindow;

    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "2905")
        {
            PinGame.SetActive(false);
            PhotosWindow.SetActive(true);
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
