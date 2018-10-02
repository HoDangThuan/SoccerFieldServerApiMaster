using System.ComponentModel;

namespace SoccerFieldServer.Core.Enums
{
    public enum WorkingShifts
    {
        [Description("Sáng")]
        Morning = 1,
        [Description("Chiều")]
        Afternoon = 2,
        [Description("Tối")]
        Evening = 3
    }
}