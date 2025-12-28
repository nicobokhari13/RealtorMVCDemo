using System.Data;

namespace MVCDemo {
    public class CustomerController {

        private MainView mainView; // only used for navigation
        private CustomerView customerView; //used to update information on this view
        private HouseView houseView;
        public HouseDatabase houseDatabase { get; private set; }
        public CustomerController(MainView m, CustomerView c, HouseView h, HouseDatabase d) {
            mainView = m;
            customerView = c;
            houseView = h;
            houseDatabase = d;
        }

        public void showMainView() {
            customerView.Hide();
            mainView.Show();
        }
        public void showCustomerView() {
            houseView.Hide();
            customerView.Show();
        }
        public void showHouseView() {
            customerView.Hide();
            houseView.Show();
        }

        public void setUpHouseView(ListViewItem listing) {
            DataRow house = getHouseForDetailedView(listing);
            houseView.setUpHouseDetails(house);
        }

        public DataRow getHouseForDetailedView(ListViewItem houseListing) {
            String id = houseListing.SubItems[3].Text;
            String searchExpression = "ID = " + id;
            DataRow[] house = houseDatabase.houses.Select(searchExpression);
            return house[0];
        }

        public DataTable executeSearch(String searchString) {
            return houseDatabase.searchHouses(searchString);
        }

    }
}
