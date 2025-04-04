﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hitPoints;

        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int MaximumDamage {  get; set; }
        public int MinimumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }
        public int RewardGold {  get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster (string name, string imageName, int maximumHitPoints, int hitPoints, int maximumDamage, int minimumDamage, int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"pack://application:,,,/Engine;component/Images/Monsters/{imageName}";
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;    
            RewardGold = rewardGold;
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;

            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
