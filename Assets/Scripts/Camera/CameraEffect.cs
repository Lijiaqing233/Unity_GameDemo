using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraEffect : PlayerData
{
    [SerializeField]
    public PlayerData playerData;

    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            time += Time.deltaTime;
            if (time >= 3)
            {
                SceneManager.LoadScene("gameover");
            }
        }
    }
}
