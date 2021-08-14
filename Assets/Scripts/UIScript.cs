using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject BuildselectionPanel;
    public GameObject UpgradePanel;
    public GameObject Build;
    public GameObject Cell;
    public GameObject InfoPanel;
    public GameObject —olor—hangePanel;
    public GameObject MiniMapPanel;
    public Text InfoText;
    private void Start()
    {
        MiniMapPanel.SetActive(false);
        BuildselectionPanel.SetActive(false);
        UpgradePanel.SetActive(false);
        InfoPanel.SetActive(false);
        —olor—hangePanel.SetActive(false);
    }
    public void CloseBuildPanel()
    {
        BuildselectionPanel.SetActive(false);
    }
    public void CloseUpgradePanel()
    {
        UpgradePanel.SetActive(false);
    }

    public void UpgradeBuild()
    {
        Build.GetComponent<Build1Scr>().UpgradeBuild();
        UpgradePanel.SetActive(false);
    }
    public void ColorChangeBuild()
    {
        Build.GetComponent<ColoredBuilding>().ColorChangeBuild();
        —olor—hangePanel.SetActive(false);
    }
    public void CloseInfoPanel()
    {
        InfoPanel.SetActive(false);
    }
    public void CloseColorPanel()
    {
        —olor—hangePanel.SetActive(false);
    }
    public void OpenMiniMap()
    {
        MiniMapPanel.SetActive(true);
    }
    public void CloseMiniMap()
    {
        MiniMapPanel.SetActive(false);
    }
    public void DestroyButton()
    {
        GameObject[] buildArray = GameObject.FindGameObjectsWithTag("build");
        for (int i = 0; i < buildArray.Length; i++)
        {
            Destroy(buildArray[i]);
        }
        GameObject[] color1Array = GameObject.FindGameObjectsWithTag("color1");
        for (int i = 0; i < color1Array.Length; i++)
        {
            Destroy(color1Array[i]);
        }
        GameObject[] color2Array = GameObject.FindGameObjectsWithTag("color2");
        for (int i = 0; i < color2Array.Length; i++)
        {
            Destroy(color2Array[i]);
        }
        GameObject[] RespPlace = GameObject.FindGameObjectsWithTag("RespPlace");
        for (int i = 0; i < RespPlace.Length; i++)
        {
            RespPlace[i].GetComponent<CellScript>().busy—ell = true;
        }
    }
}