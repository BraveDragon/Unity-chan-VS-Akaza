using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Text BlinkText;
    const float FlipTime = 0.7f;//切り替えまでの時間
    private float TimeCount = 0.0f;//タイムカウント

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("Start");
        }
        TimeCount += Time.deltaTime;
        if (TimeCount >= FlipTime)
        {
            BlinkText.enabled = !BlinkText.enabled;
            TimeCount = 0.0f;
        }
    }
}
