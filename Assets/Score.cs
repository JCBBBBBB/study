using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0; // 인스턴스 생성 안해도 됨
    /// </summary>
    // Start is called before the first frame update
    public static int bestScore = 0;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString(); // str(score)
    }
}
