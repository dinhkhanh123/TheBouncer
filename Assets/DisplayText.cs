using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public TMP_Text obj_text;
    public TMP_InputField display;
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    // Update is called once per frame
   public void Create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name",obj_text.text);
        PlayerPrefs.Save();
    }
}
