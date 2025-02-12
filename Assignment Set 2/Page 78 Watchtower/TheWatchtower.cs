// Written By: Patrick Leonard
// 02/03/25

namespace TheWatchtower
{
    public static class Watchtower
    {
        // Methods
        public static WatchRegion PosToRegion(int xPos, int yPos) {
            if (xPos < 0)
            {
                if (yPos < 0) return WatchRegion.Southwest;
                if (yPos > 0) return WatchRegion.Northwest;
                return WatchRegion.West;
            }
            else if (xPos > 0)
            {
                if (yPos < 0) return WatchRegion.Northeast;
                if (yPos > 0) return WatchRegion.East;
                return WatchRegion.Southeast;
            }
            else
            {
                if (yPos < 0) return WatchRegion.South;
                if (yPos > 0) return WatchRegion.North;
                return WatchRegion.Center;
            } 
        }

        public static string RegionToString(WatchRegion region)
        {
            return region switch
            {
                WatchRegion.Center => "The enemy is here!",
                _ => $"The enemy is to the {region}!",
            };
        }

        public static string PosToString(int xPos, int yPos)
        {
            return RegionToString(PosToRegion(xPos, yPos));
        }

        // Enums
        public enum WatchRegion
        {
            Northwest,
            North,
            Northeast,
            West,
            Center,
            East,
            Southwest,
            South,
            Southeast
        }
    }
}
