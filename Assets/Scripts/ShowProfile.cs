using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowProfile : MonoBehaviour, IPointerClickHandler
{
    public GameObject profile;
    bool vis;
    // Start is called before the first frame update
    void Start()
    {
        vis = false;
        profile.SetActive(vis);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ProfileVisChanged()
    {
        vis = !vis;
        profile.SetActive(vis);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Hi");
        ProfileVisChanged();
    }
}
