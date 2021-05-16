using UnityEngine;

public class SimpleGun : MonoBehaviour, IGun
{
    [SerializeField]
    private Caster caster;

    [SerializeField]
    private SimpleProjectileData projectileData;

    /// <summary>
    /// Fire projectile
    /// </summary>
    public void Fire()
    {
        caster.Cast(transform.position, transform.rotation, projectileData);
    }
}
