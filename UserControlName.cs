using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gyur_Motorbike_21IS.FolderforModel;

namespace Gyur_Motorbike_21IS
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }



        public void Fill(Table_Motorbike Motorbike)
        {
            labelID.Text = Motorbike.ID.ToString();
            labelModel.Text = Motorbike.Model;
            labelBrand.Text = Motorbike.Brand;
            labelPrice.Text = Motorbike.Price.ToString();
            labelHorsepower.Text = Motorbike.Horsepower.ToString();
            labelMileage.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");

        }
        private void UserControlName_Load(object sender, EventArgs e)
        {

        }
    }
}
