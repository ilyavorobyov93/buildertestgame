using UnityEngine;
public class RespawnerScript : MonoBehaviour
{
    private bool TenXTen;

    [SerializeField] GameObject[] Other = new GameObject[75];
    void Awake()
    {
        CheckBool();
    }
    void Update()
    {
        CheckBool();
    }
    private void CheckBool()
    {
        if (TenXTen == false)
        {
            for (int i = 0; i < Other.Length; i++)
            {
                Other[i].SetActive(false);
            }
        }
        else if (TenXTen == true)
        {
            for (int i = 0; i < Other.Length; i++)
            {
                Other[i].SetActive(true);
            }
        }
    }
    public void ToggleOnScreen()
    {
        if (TenXTen == false)
        {
            TenXTen = true;
        }
        else if (TenXTen == true)
        {
            TenXTen = false;
        }
    }
}
