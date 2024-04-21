using DisProject.Models;
// GlobalData.cs
using System.Collections.Generic;
namespace DisProject.Global_Variables
{
    public static class GlobalData
    {
        public static Dictionary<int, SignUpModel> Users { get; } = new Dictionary<int, SignUpModel>();
        //public static Dictionary<int, ReviewModel> Reviews { get; } = new Dictionary<int, ReviewModel>();
    }

}
