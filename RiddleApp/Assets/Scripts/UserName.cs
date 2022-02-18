using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public string nameUser;
    public string saveName;

    public Text inputText;
    public Text loadedName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameUser = PlayerPrefs.GetString("User_" + "");
        loadedName.text = nameUser;
    }


    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("User_", saveName);
    }
}
