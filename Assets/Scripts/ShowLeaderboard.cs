using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowLeaderboard : MonoBehaviour , IPointerClickHandler
{
    public GameObject leaderboard;
    bool vis;
    // Start is called before the first frame update
    void Start()
    {
        vis = false;
        leaderboard.SetActive(vis);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeaderboardVisChanged()
    {
        vis = !vis;
        leaderboard.SetActive(vis);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Hi");
        LeaderboardVisChanged();
    }
}
