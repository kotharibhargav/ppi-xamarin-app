using PPI.Model;
using PPI.Views;
using PPI.Views.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPI.Utilities
{
    public static class Common
    {
        public static MasterMainPageDetail MasterPage { get; set; }
        public static List<TypesModel> typesModel = new List<TypesModel>();
    }
}
