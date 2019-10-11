using PPI.Model;
using PPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPI.Views.TabbedContentPage.DaysContentPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreView : ContentView
    {
        List<TypesModel> typesModels = new List<TypesModel>();
        bool _isAgenda = false;
        public PreView()
        {
            InitializeComponent();
            _isAgenda = false;
            BindData();
        }

        public PreView(bool isAgenda)
        {
            InitializeComponent();
            _isAgenda = isAgenda;
            BindAgendaData();
        }

        public void BindData()
        {
            typesModels.Clear();
            typesModels.Add(new TypesModel() { id = 1, Time = "5:00 PM", status = "Check-In", Desc = "Goizueta Business School Arches" });
            typesModels.Add(new TypesModel() { id = 2, Time = "10:00 PM", status = "Check-In", Desc = "Goizueta Business School Arches" });
            typesModels.Add(new TypesModel() { id = 3, Time = "3:00 PM", status = "Check-In", Desc = "Goizueta Business School Arches" });

            flvTypes.FlowItemsSource = typesModels.ToList();
        }

        public void BindAgendaData()
        {
            typesModels.Clear();
            typesModels = Common.typesModel.ToList();
            flvTypes.FlowItemsSource = typesModels.ToList();
        }

        private void BtnAdd_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModels)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsAddImage == "AddSelected.png")
                        {
                            item.IsAddImage = "Add.png";
                        }
                        else
                        {
                            item.IsAddImage = "AddSelected.png";

                        }
                    }
                    else
                    {
                        item.IsAddImage = "Add.png";
                    }
                }

                Common.typesModel.Add(mImages);
            }
        }

        private void BtnNotification_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModels)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsNotificationImage == "BellSelected.png")
                        {
                            item.IsNotificationImage = "Bell.png";
                        }
                        else
                        {
                            item.IsNotificationImage = "BellSelected.png";
                        }
                    }
                    else
                    {
                        item.IsNotificationImage = "Bell.png";
                    }
                }
            }
        }

        private void FlvTypes_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Type = e.Item;
        }
    }
}