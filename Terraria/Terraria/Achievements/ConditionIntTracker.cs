﻿/*
  _____                 ____                 
 | ____|_ __ ___  _   _|  _ \  _____   _____ 
 |  _| | '_ ` _ \| | | | | | |/ _ \ \ / / __|
 | |___| | | | | | |_| | |_| |  __/\ V /\__ \
 |_____|_| |_| |_|\__,_|____/ \___| \_/ |___/
          <http://emudevs.com>
             Terraria 1.3
*/

namespace Terraria.Achievements
{
    public class ConditionIntTracker : AchievementTracker<int>
    {
        public ConditionIntTracker()
            : base(TrackerType.Int) { }

        public ConditionIntTracker(int maxValue)
            : base(TrackerType.Int)
        {
            _maxValue = maxValue;
        }

        public override void ReportUpdate() { }

        protected override void Load() { }
    }
}