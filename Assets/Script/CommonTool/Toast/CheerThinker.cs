using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheerThinker : GistThickness<CheerThinker>
{
    public string Genu;

    public void FirnCheer(string info)
    {
        Genu = info;
        UIManager.BisFeedback().FirnUICharm(nameof(Cheer));
    }
}
