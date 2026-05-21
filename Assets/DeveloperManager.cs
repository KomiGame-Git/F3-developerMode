using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DeveloperManager : MonoBehaviour
{
    [SerializeField]
    private GameObject developerCanvas;
    [SerializeField]
    private bool developerMode = false;

    [SerializeField]
    private TextMeshProUGUI developerCoinText;
    [SerializeField]
    private TextMeshProUGUI developerSpecialCoinText;

    [SerializeField]
    private CoinManager coinManager;

    private bool developerActionFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        if(developerCanvas == null)
        {
            developerCanvas = GameObject.Find("DeveloperCanvas");
        }
        UpdateDeveloperCoinText();
        UpdateDeveloperSpecialCoinText();
        CanvasActivation(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F3))
        {
            if (developerActionFlag)
            {
                developerActionFlag = false;
            }
            else
            {
                SwitchDeveloperMode();
            }
            CanvasActivation(developerMode);
        }

        if(Input.GetKey(KeyCode.F3) && Input.GetKeyUp(KeyCode.Alpha1))
        {
            developerActionFlag = true;
            coinManager.AddCoin(100);
            UpdateDeveloperCoinText();
        }
        if (Input.GetKey(KeyCode.F3) && Input.GetKeyUp(KeyCode.Alpha2))
        {
            developerActionFlag = true;
            coinManager.AddSpecialCoin(100);
            UpdateDeveloperSpecialCoinText();
        }
    }

    void SwitchDeveloperMode()
    {
        developerMode = !developerMode;
    }

    void CanvasActivation(bool active)
    {
        if(developerCanvas != null)
        {
            developerCanvas.SetActive(active);
        }
    }

    public void UpdateDeveloperCoinText()
    {
        if(developerCoinText != null)
        {
            developerCoinText.text = "Coin: " + coinManager.GetCoinCount().ToString();
        }
    }

    public void UpdateDeveloperSpecialCoinText()
    {
        if (developerSpecialCoinText != null)
        {
            developerSpecialCoinText.text = "Special Coin: " + coinManager.GetSpecialCoinCount().ToString();
        }
    }
}
