using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject weaponPrefab;
    public int Damage = 1;
    public float FireRate = .5f;
    public GameObject HitVFXPrefab;
    public bool isAutomatic = false;
    public bool CanZoom = false;
}

