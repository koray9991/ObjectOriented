using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SVS.WeaponSystem;

namespace EnemyAI
{
    public class ShootActionAI : MonoBehaviour
    {
        private Player player;
        private Weapon weapon;
        private void Awake()
        {
            player = FindObjectOfType<Player>();
            weapon = GetComponentInChildren<Weapon>();
        }
        void Update()
        {
            if (player.isAlive)
            {
                weapon.PerformAttack();
            }
        }
    }
}