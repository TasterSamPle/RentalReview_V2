using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalReview_V2
{
    public partial class Van_Screen : Form
    {

        List<Van> ListOfVans = new List<Van>();

        public Van_Screen()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Van Van = new Van();

            ListOfVans.Add(Van);
            Van.Registration = Reg_Add.Text;
            Van.Wheels = int.Parse(Whe_Add.Text);
            Van.Weight = int.Parse(Wei_Add.Text);
            Van.Height = int.Parse(Hei_Add.Text);
            Output.Text = "Vehicle added to database.";
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            Van Van = new Van();
            switch (Check.SelectedItem)
            {
                case "VanA":
                    if (ListOfVans.Count == 0)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        Van = ListOfVans.ElementAt(0);
                        Output.Text = "Registration number: " + Van.Registration + "\r\nWheels" + Van.Wheels +
                            "\r\nWeight(KG)" + Van.Weight + "\r\nPassangers" + Van.Height;
                        break;
                    }

                case "VanB":
                    if (ListOfVans.Count < 2)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        Van = ListOfVans.ElementAt(1);
                        Output.Text = "Registration number: " + Van.Registration + "\r\nWheels" + Van.Wheels +
                            "\r\nWeight(KG)" + Van.Weight + "\r\nPassangers" + Van.Height;
                        break;
                    }


                case "VanC":
                    if (ListOfVans.Count < 3)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        Van = ListOfVans.ElementAt(2);
                        Output.Text = "Registration number: " + Van.Registration + "\r\nWheels" + Van.Wheels +
                            "\r\nWeight(KG)" + Van.Weight + "\r\nPassangers" + Van.Height;
                        break;
                    }
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            switch (Select_Edit.SelectedItem)
            {
                case "VanA":
                    Reg_Edit.Text = ListOfVans.ElementAt(0).Registration;
                    Whe_Edit.Text = ListOfVans.ElementAt(0).Wheels.ToString();
                    Wei_Edit.Text = ListOfVans.ElementAt(0).Weight.ToString();
                    Hei_Edit.Text = ListOfVans.ElementAt(0).Height.ToString();

                    break;
                case "VanB":
                    Reg_Edit.Text = ListOfVans.ElementAt(1).Registration;
                    Whe_Edit.Text = ListOfVans.ElementAt(1).Wheels.ToString();
                    Wei_Edit.Text = ListOfVans.ElementAt(1).Weight.ToString();
                    Hei_Edit.Text = ListOfVans.ElementAt(1).Height.ToString();
                    break;
                case "VanC":
                    Reg_Edit.Text = ListOfVans.ElementAt(2).Registration;
                    Whe_Edit.Text = ListOfVans.ElementAt(2).Wheels.ToString();
                    Wei_Edit.Text = ListOfVans.ElementAt(2).Weight.ToString();
                    Hei_Edit.Text = ListOfVans.ElementAt(2).Height.ToString();
                    break;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Van Van = new Van();
            switch (Select_Edit.SelectedItem)
            {
                case "VanA":
                    Van = ListOfVans.ElementAt(0);
                    ListOfVans.Remove(ListOfVans.ElementAt(0));
                    Output.Text = "Van removed from database";
                    break;
            }
        }
    }
}