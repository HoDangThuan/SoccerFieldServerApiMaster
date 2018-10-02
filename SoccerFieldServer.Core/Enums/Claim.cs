
using System.ComponentModel;

namespace SoccerFieldServer.Core.Enums
{
    public enum Claim
    {
        [Description("bookfield")]
        Bookfield = 1,
        [Description("createNewGrSoccerField")]
        CreateNewGrSoccerField = 2,
        [Description("createNewSoccerField")]
        CreateNewSoccerField = 3
    }
}
