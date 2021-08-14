using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class Build1Scr : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Mesh lvl2;
    [SerializeField] private Mesh lvl3;
    [SerializeField] private Mesh lvl4;
    [SerializeField] private Mesh lvl5;

    [SerializeField] private TMP_Text Lvltext;
    private MeshFilter _meshfilter;
    private string lvltextString;
    private int lvl;

    private GameObject BuildUpgradePanel;
    void Awake()
    {
        BuildUpgradePanel = Camera.main.GetComponent<UIScript>().UpgradePanel;
        _meshfilter = GetComponent<MeshFilter>();
        lvltextString = "Уровень ";
        lvl = 1;
        Lvltext.text = lvltextString + lvl.ToString();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Camera.main.GetComponent<UIScript>().Build = gameObject;
        BuildUpgradePanel.SetActive(true);
    }
    public void UpgradeBuild()
    {
        if (lvl == 1)
        {
            lvl++;
            Lvltext.text = lvltextString + lvl.ToString();
            _meshfilter.mesh = lvl2;
        }
        else if (lvl == 2)
        {
            lvl++;
            Lvltext.text = lvltextString + lvl.ToString();
            _meshfilter.mesh = lvl3;
        }
        else if (lvl == 3)
        {
            lvl++;
            Lvltext.text = lvltextString + lvl.ToString();
            _meshfilter.mesh = lvl4;
        }
        else if (lvl == 4)
        {
            lvl++;
            Lvltext.text = lvltextString + lvl.ToString();
            _meshfilter.mesh = lvl5;
        }
    }
}
