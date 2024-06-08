

namespace _hometask_Class
{
    public class Gun
    {
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
        public int CurrentBullet { get; set; }
        public int TotalBullet { get; set; }
        public string Type { get; set; }

        public void Fire()
        {
            if (Type == "assault")
                CurrentBullet = 0;
            else if (Type == "sniper")
                CurrentBullet--;
        }

        public void Reload()
        {
            if (TotalBullet >= MaxCapacity)
            {
                CurrentBullet = MaxCapacity;
                TotalBullet -= MaxCapacity;
            }
            else
            {
                CurrentBullet = TotalBullet;
                TotalBullet = 0;
            }
        }

        public string GetGunStatus()
        {
            return $"Name: {Name}, CurrentBullet: {CurrentBullet}, Remaining TotalBullet: {TotalBullet}, Type: {Type}";
        }
    }
}
