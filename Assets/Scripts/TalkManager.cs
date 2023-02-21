using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "엄마 : 일어났니?", "엄마 : 지금 8시 반이야!", "엄마 : 지각이야 빨리가!" });
        talkData.Add(100, new string[] { "이것은 책상이다." });
        talkData.Add(200, new string[] { "이것은 책가방이다." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
        return talkData[id][talkIndex];
    }
}
