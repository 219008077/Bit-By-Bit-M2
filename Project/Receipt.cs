using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Receipt : Form
    {
        public int TicketID { get; private set; }
        public string CollectionType { get; set; }
        public Receipt(int ticketID, string col)
        {
            InitializeComponent();
            TicketID = ticketID;
            CollectionType = col;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.Fill(this.groupPmb8DataSet.Items);
            var items = this.itemsTableAdapter.GetDataByTicketID(TicketID);
            decimal total = 0;
            foreach (var item in items)
            {
                Items.Items.Add($"Receipt for: {item.ItemName}");
                Items.Items.Add("...................................");
                var itemsServices = this.itemServicesTableAdapter.GetDataBy(item.ItemId);
                foreach (var service in itemsServices)
                {
                    int qua = int.Parse(item.Quantity);
                    total += service.Price * qua;
                    var display = $"{service.ServiceName} - {(service.Price * qua).ToString("C")} ({service.Price:C} x {item.Quantity})";
                    Items.Items.Add(display);
                }
            }
            if(CollectionType.ToLower() == "delivery")
            {
                total += 50;
                Items.Items.Add("Collection (delivery - R50.00)");
            }
            else
            {
                Items.Items.Add("Collection (pickup - R00.00)");
            }

            Items.Items.Add("----------------------------------");
            Items.Items.Add($"Total ------------------- {total:C}");

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
