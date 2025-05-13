using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbgm : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    static public startbgm instance;

    private void Awake()
    {
        
        if (instance == null)
        {
           
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    //シングルトン設定ここまで

    private string beforeScene;//string型の変数beforeSceneを宣言 

    void Start()
    {
        beforeScene = SceneManager.GetActiveScene().name;//起動時のシーン名 を代入しておく


        audioSource.Play();//A_BGMのAudioSourceコンポーネントに割り当てたAudioClipを再生



        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    private void Update()
    {
        
    }



    //シーンが切り替わった時に呼ばれるメソッド　
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定
        //Scene1からScene2へ
        print(nextScene.name);
        
        if (beforeScene == "Start" && nextScene.name == "Boxinggame")
        {
            audioSource.Stop();//A_BGMを停止
        }
        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }
}
