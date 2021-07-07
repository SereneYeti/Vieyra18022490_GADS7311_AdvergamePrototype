using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowAddUser : MonoBehaviour, IPointerClickHandler
{
    public GameObject addUser;
    bool vis;
    // Start is called before the first frame update
    void Start()
    {
        vis = false;
        addUser.SetActive(vis);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LeaderboardVisChanged()
    {
        vis = !vis;
        addUser.SetActive(vis);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Hi");
        LeaderboardVisChanged();
    }
}
