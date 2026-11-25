// ArchNet · Facade Pattern — sample
// A facade gives one simple entry point to several systems that work together.
// Here, ShopFacade.Buy checks the wallet, the inventory space and the item level in one
// call, so the shop UI never talks to those three systems directly.
// Add ShopFacadeExample to a GameObject and press Play.
// Docs: https://archnet-plateform.fr/#DesignPatternFacade

using UnityEngine;

namespace ArchNet.Samples.Facade
{
    // Three independent systems with their own rules.
    public class Wallet
    {
        public int Coins = 100;
        public bool CanPay(int price) => Coins >= price;
        public void Pay(int price) => Coins -= price;
    }

    public class Inventory
    {
        public int FreeSlots = 1;
        public bool HasRoom => FreeSlots > 0;
        public void Add(string item) => FreeSlots--;
    }

    public class PlayerLevel
    {
        public int Level = 3;
        public bool CanUse(int requiredLevel) => Level >= requiredLevel;
    }

    /// <summary>The facade: the only class the shop UI needs to know.</summary>
    public class ShopFacade
    {
        readonly Wallet _wallet;
        readonly Inventory _inventory;
        readonly PlayerLevel _level;

        public ShopFacade(Wallet wallet, Inventory inventory, PlayerLevel level)
        {
            _wallet = wallet;
            _inventory = inventory;
            _level = level;
        }

        /// <summary>Buys the item when every system agrees; returns why not otherwise.</summary>
        public bool Buy(string item, int price, int requiredLevel, out string reason)
        {
            if (!_level.CanUse(requiredLevel)) reason = $"needs level {requiredLevel}";
            else if (!_wallet.CanPay(price)) reason = "not enough coins";
            else if (!_inventory.HasRoom) reason = "inventory full";
            else
            {
                _wallet.Pay(price);
                _inventory.Add(item);
                reason = null;
                return true;
            }
            return false;
        }
    }

    public class ShopFacadeExample : MonoBehaviour
    {
        void Start()
        {
            var shop = new ShopFacade(new Wallet(), new Inventory(), new PlayerLevel());
            Log(shop, "Potion", price: 20, requiredLevel: 1);
            Log(shop, "Shield", price: 50, requiredLevel: 2);     // inventory full now
            Log(shop, "Dragon sword", price: 90, requiredLevel: 10);
        }

        static void Log(ShopFacade shop, string item, int price, int requiredLevel)
        {
            bool bought = shop.Buy(item, price, requiredLevel, out string reason);
            Debug.Log(bought ? $"Bought {item}" : $"Cannot buy {item}: {reason}");
        }
    }
}
