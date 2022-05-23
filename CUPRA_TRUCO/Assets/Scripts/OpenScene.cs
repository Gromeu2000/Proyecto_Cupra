using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScene : MonoBehaviour
{
    public List<GameObject> Screens_List;

    public void OpenHome()
    {
        for (int i = 0; i < Screens_List.Count; i++)
        {
            Screens_List[i].SetActive(false);
        }
        Screens_List[0].SetActive(true);
    }
    public void OpenAllApps()
    {
        for (int i = 0; i < Screens_List.Count; i++)
        {
            Screens_List[i].SetActive(false);
        }
        Screens_List[1].SetActive(true);
    }

    public void OpenMaps()
    {
        for(int i = 0; i < Screens_List.Count; i++)
        {
            Screens_List[i].SetActive(false);
        }
        Screens_List[2].SetActive(true);
    }

    public void OpenDiscord()
    {
        for (int i = 0; i < Screens_List.Count; i++)
        {
            Screens_List[i].SetActive(false);
        }
        Screens_List[3].SetActive(true);
    }

    

}
