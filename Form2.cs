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
    public partial class Car : Form
    {

        List<CarForm> ListOfCars = new List<CarForm>();

        public Car()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm();

            ListOfCars.Add(car);
            car.Registration = Reg_Add.Text;
            car.Wheels = int.Parse(Whe_Add.Text);
            car.Weight = int.Parse(Wei_Add.Text);
            car.NumberOfPassengers = int.Parse(Pas_Add.Text);
            Output.Text = "Vehicle added to database.";
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm();
            switch (Check.SelectedItem)
            {
                case "CarA":
                    if (ListOfCars.Count == 0)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        car = ListOfCars.ElementAt(0);
                        Output.Text = "Registration number: " + car.Registration + "\r\nWheels" + car.Wheels +
                            "\r\nWeight(KG)" + car.Weight + "\r\nPassangers" + car.NumberOfPassengers;
                        break;
                    }

                case "CarB":
                    if (ListOfCars.Count < 2)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        car = ListOfCars.ElementAt(1);
                        Output.Text = "Registration number: " + car.Registration + "\r\nWheels" + car.Wheels +
                            "\r\nWeight(KG)" + car.Weight + "\r\nPassangers" + car.NumberOfPassengers;
                        break;
                    }


                case "CarC":
                    if (ListOfCars.Count < 3)
                    {
                        Output.Text = "Error";
                        break;
                    }
                    else
                    {
                        car = ListOfCars.ElementAt(2);
                        Output.Text = "Registration number: " + car.Registration + "\r\nWheels" + car.Wheels +
                            "\r\nWeight(KG)" + car.Weight + "\r\nPassangers" + car.NumberOfPassengers;
                        break;
                    }
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            switch (Select_Edit.SelectedItem)
            {
                case "CarA":
                    Reg_Edit.Text = ListOfCars.ElementAt(0).Registration;
                    Whe_Edit.Text = ListOfCars.ElementAt(0).Wheels.ToString();
                    Wei_Edit.Text = ListOfCars.ElementAt(0).Weight.ToString();
                    Pas_Edit.Text = ListOfCars.ElementAt(0).NumberOfPassengers.ToString();

                    break;
                case "CarB":
                    Reg_Edit.Text = ListOfCars.ElementAt(1).Registration;
                    Whe_Edit.Text = ListOfCars.ElementAt(1).Wheels.ToString();
                    Wei_Edit.Text = ListOfCars.ElementAt(1).Weight.ToString();
                    Pas_Edit.Text = ListOfCars.ElementAt(1).NumberOfPassengers.ToString();
                    break;
                case "CarC":
                    Reg_Edit.Text = ListOfCars.ElementAt(2).Registration;
                    Whe_Edit.Text = ListOfCars.ElementAt(2).Wheels.ToString();
                    Wei_Edit.Text = ListOfCars.ElementAt(2).Weight.ToString();
                    Pas_Edit.Text = ListOfCars.ElementAt(2).NumberOfPassengers.ToString();
                    break;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm();
            switch (Select_Edit.SelectedItem)
            {
                case "CarA":
                    car = ListOfCars.ElementAt(0);
                    ListOfCars.Remove(ListOfCars.ElementAt(0));
                    Output.Text = "Car removed from database";
                    break;
            }
        }
    }
}