using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// === | UI설정 | ===
/// </summary>
public class CubeGameUI : MonoBehaviour
{
    /// <summary>
    /// public | ======================================
    /// </summary>

    public TextMeshProUGUI timerText;       //UI tmp변수 선언
    public float timer;                     //타이머 실수 선언

    /// <summary>
    /// private | ======================================
    /// </summary>

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;                                    //타이머 시간이 늘어난다.
        timerText.text = "생존 시간 : " + timer.ToString("0.00");   //문자열 형태로 변환하여 보여준다.
    }
}
