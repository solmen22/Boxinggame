using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*public class GameTimer : MonoBehaviour
{
    public float Timer = 30;
    public Text TimerText;
    
    public Gamecontroller Gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0 && !Gamecontroller.Stop)
        {
            Timer -= Time.deltaTime;
        }
       
        TimerText.text = "Time: " + ((int)Timer).ToString();

        
    }
}*/
public class GameTimer : MonoBehaviour
{
    public float Timer = 30;
    public Text TimerText;
    
   
    public Gamecontroller Gamecontroller;
    

    private Color originalColor;
    private bool isFlashing = false;
    private float flashSpeed = 4f; // 点滅速度
    private float scaleAmplitude = 0.2f; // スケーリングの振れ幅
    private float scaleSpeed = 4f; // スケーリングの速度
    private Vector3 originalScale;
    
   
    void Start()
    {
        originalColor = TimerText.color;
        originalScale = TimerText.transform.localScale;
    }

    void Update()
    {
        if (Timer > 0 && !Gamecontroller.Stop)
        {
            Timer -= Time.deltaTime;
        }

        TimerText.text = "Time: " + Mathf.CeilToInt(Timer).ToString();

        if (Timer <= 5 && !isFlashing)
        {
            isFlashing = true;
           
            

        }

        if (isFlashing)
        {
            // 色を赤と元の色で点滅させる
            float t = Mathf.PingPong(Time.time * flashSpeed, 1f);
            TimerText.color = Color.Lerp(originalColor, Color.red, t);

            // 文字サイズを揺らす
            float scale = 1f + Mathf.Sin(Time.time * scaleSpeed) * scaleAmplitude;
            TimerText.transform.localScale = originalScale * scale;
        }
    }
}
