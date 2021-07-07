using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUser : MonoBehaviour
{
    public InputField userame;
    public string user;
    public Text userToadd;
    public GameObject foundUser;
    bool vis;
    // Start is called before the first frame update
    void Start()
    {
        vis = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetUserName()
    {
        user = userame.text;
        userToadd.text = "Found user: " + user;
    }

    public void ChangeVis()
    {
        vis = !vis;
        foundUser.SetActive(vis);
    }
    public void UserAdded()
    {
        userToadd.text = "User " + user + " Added.";
    }
}
