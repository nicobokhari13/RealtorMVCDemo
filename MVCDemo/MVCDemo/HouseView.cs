using System.Data;

namespace MVCDemo {
    public partial class HouseView : Form {

        CustomerController controller;
        public HouseView() {
            InitializeComponent();
        }

        public void setCustomerViewController(CustomerController c) {
            controller = c;
        }
        private void CustomerViewButton_Click(object sender, EventArgs e) {
            controller.showCustomerView();
        }

        public void setUpHouseDetails(DataRow house) {
            String address = house["Address"].ToString();
            address += " ";
            address += house["City"].ToString();
            address += " ";
            address += house["Zip"].ToString();
            this.Address_Text.Text = address;
            this.PropertyType_Text.Text = house["Property Type"].ToString();
            this.Year_Text.Text = house["Year Built"].ToString();
            this.NumberBedrooms_Text.Text = house["Number of Bedrooms"].ToString();
            this.Price_Text.Text = house["Price"].ToString();
        }
    }
}
