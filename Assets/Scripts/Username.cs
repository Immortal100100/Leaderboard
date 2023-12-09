using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Username : MonoBehaviour
{
    public TMP_InputField user_input;
    public void OnClick()
    {
        PlayerPrefs.SetString("username", user_input.text);
        SceneManager.LoadScene(1);
    }
}
