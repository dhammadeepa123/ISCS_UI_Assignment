using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Panels 4")]
    public GameObject homePanel;
    public GameObject shopPanel;
    public GameObject inventoryPanel;
    public GameObject settingsPanel;

    void Start()
    {
   
        OpenHome();
    }

    public void OpenHome()
    {
        homePanel.SetActive(true);
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void OpenShop()
    {
        homePanel.SetActive(false);
        shopPanel.SetActive(true);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void OpenInventory()
    {
        homePanel.SetActive(false);
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void OpenSettings()
    {
        homePanel.SetActive(false);
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
}