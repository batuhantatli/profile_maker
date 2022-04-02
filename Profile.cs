using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    #region SIngleton : Profile
    public static Profile Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    public Image _avatarBackground;
    public Image _avatarSkinColor;
    public Image _avatarHair;
    public Image _avatarBrow;
    public Image _avatarEye;
    public Image _avatarNose;
    public Image _avatarMouth;
    public Image _avatarCloth;
    public Image _avatarAdds;
}
