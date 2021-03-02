using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CabinBookingApp
{
    public partial class serviceForm : Form
    {
        
        public serviceForm(string email)
        {
            InitializeComponent();
            UpdateListBox(email);
        }

        public async void UpdateListBox(string email)
        {
            RestAPI api = new RestAPI();
            List<Cabin> cabins = await api.GetCabins(email);
            List<Reservation> reservations = await api.GetReservation();
            List<Service> services = await api.GetServices();

            cabinList.Items.Clear();

            foreach(Cabin cabin in cabins)
            {
                cabinList.Items.Add(cabin.id + " address: " + cabin.address + " size: " + cabin.size +  " owner: " + cabin.owner);
            }

            reservationsBox.Items.Clear();

             foreach (Reservation reservation in reservations)
             {
                 reservationsBox.Items.Add(reservation.id + " Cabin: " + reservation.cabinId + " Service: " + reservation.services  + " Date: " + reservation.dates);
             } 

            serviceBox.Items.Clear();

            foreach (Service service in services)
            {
                serviceBox.Items.Add(service.id + " " + service.name + " price: " + service.price + "€");
            }

            serviceBox2.Items.Clear();

            foreach (Service service in services)
            {
                serviceBox2.Items.Add(service.id + " " + service.name + " price: " + service.price + "€");
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            string choice = cabinList.GetItemText(cabinList.SelectedItem);
            string[] chunks = choice.Split(' ');
            string cabinId = chunks[0];
            Console.WriteLine(cabinId);

            string choise2 = serviceBox.GetItemText(serviceBox.SelectedItem);
            string[] chunks2 = choise2.Split(' ');
            string services = chunks2[1];
            Console.WriteLine(services);

            string dates = monthCalendar1.SelectionRange.Start.ToShortDateString();
            Console.WriteLine(dates);

            Reservation reservation = new Reservation();
            reservation.cabinId = cabinId;
            reservation.services = services;
            reservation.dates = dates;

            RestAPI api = new RestAPI();
            await api.SaveReservation(reservation);
            //UpdateListBox();

        }
        private async void saveButtonBooking_Click(object sender, EventArgs e)
        {
            string choice = reservationsBox.GetItemText(reservationsBox.SelectedItem);
            string[] chunks = choice.Split(' ');
            int id = System.Convert.ToInt32(chunks[0]);

            string choise2 = serviceBox2.GetItemText(serviceBox2.SelectedItem);
            string[] chunks2 = choise2.Split(' ');
            string services = chunks2[1];
            Console.WriteLine(services);

            string choise3 = reservationsBox.GetItemText(reservationsBox.SelectedItem);
            string[] chunks3 = choise3.Split(' ');
            string cabindId = chunks3[2];
            Console.WriteLine(services);

            string dates = monthCalendar2.SelectionRange.Start.ToShortDateString();
            Console.WriteLine(dates);

            Reservation reservation = new Reservation();
            reservation.id = id;
            reservation.cabinId = cabindId;
            reservation.services = services;
            reservation.dates = dates;

            RestAPI api = new RestAPI();
            await api.UpdateReservation(reservation, id);
            //UpdateListBox();
        }

        private async void deleteButtonBooking_Click_1(object sender, EventArgs e)
        {
            string choice = reservationsBox.GetItemText(reservationsBox.SelectedItem);
            string[] chunks = choice.Split(' ');
            string id = chunks[0];

            RestAPI api = new RestAPI();
            await api.DeleteReservation(id);
            //UpdateListBox();
        }

        
    }
}
