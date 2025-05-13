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
    //�V���O���g���ݒ肱���܂�

    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 

    void Start()
    {
        beforeScene = SceneManager.GetActiveScene().name;//�N�����̃V�[���� �������Ă���


        audioSource.Play();//A_BGM��AudioSource�R���|�[�l���g�Ɋ��蓖�Ă�AudioClip���Đ�



        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    private void Update()
    {
        
    }



    //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h�@
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //�V�[�����ǂ��ς�������Ŕ���
        //Scene1����Scene2��
        print(nextScene.name);
        
        if (beforeScene == "Start" && nextScene.name == "Boxinggame")
        {
            audioSource.Stop();//A_BGM���~
        }
        //�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
        beforeScene = nextScene.name;
    }
}
