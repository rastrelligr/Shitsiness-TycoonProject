using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public Image[] tabImage;
    public GameObject[] pages;
    public GameObject menuCanvas;
    public GameObject button1;
    public GameObject button2;

    int currentTab = 0;
    int minTab = 0;
    int maxTab = 3;

    void Start()
    {
        ActivateTab(0);
        
    }
    void Update() //A D Press
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeTab(-1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeTab(-1);
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeTab(1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeTab(1);
        }
    }

    void ChangeTab(int tabNo)
    {
        currentTab += tabNo;
        currentTab = Mathf.Clamp(currentTab, minTab, maxTab);
        ActivateTab(currentTab);
    }

    public void ActivateTab(int tabNo) //Tab Number
    {
        for(int i = 0; i < tabImage.Length; i++)
        {
            pages[i].SetActive(false);
            tabImage[i].color = Color.gray;
        }
        pages[tabNo].SetActive(true);
        tabImage[tabNo].color = Color.white;

        if (!menuCanvas.activeSelf)
        {
            menuCanvas.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(false);
        }
    }
}
