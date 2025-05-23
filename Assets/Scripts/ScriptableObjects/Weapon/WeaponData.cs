using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponData", menuName = "Weapons/WeaponData")]
public class WeaponData : ScriptableObject
{
    public enum WeaponType
    {
        Melee,
        Firearm,
        Throwable
    }
    public enum AmmoType
    {
        Shotgun,
        Uzi,
        Pistol
    }

    [Header("General Information")]
    public string weaponName;
    public WeaponType weaponType;
    public Sprite icon;
    public GameObject weaponPrefab;

    [Header("Firearm Settings")]
    public GameObject bulletPrefab;
    public float fireRate;
    public int ammoCapacity;
    public AmmoType ammoType;
    public float reloadTime;
    public int pelletCount;
    public float spread;
    public bool unloaded = false;

    [Header("Melee Settings")]
    public float attackRange;
    public float attackSpeed;
    public int attackDamage;

    [Header("Throwable Settings")]
    public float throwForce;
    public float explosionRadius;
    public float explosionDamage;
    public bool detonatesOnImpact;

    [Header("Audio & Effects")]
    public AudioClip attackSound;
    public ParticleSystem attackEffect;
}
