using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trans : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(1000);
        SceneManager.LoadScene("Boxinggame");
    }
}
