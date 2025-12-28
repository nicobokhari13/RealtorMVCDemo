namespace MVCDemo {
    public class MainController {
        public Form mainView { get; private set; }
        public Form customerView { get; private set; }
        public Form realtorView { get; private set; }
        //private Form RealtorView; 
        public MainController(MainView m, CustomerView c, RealtorView r) {
            this.mainView = m;
            this.customerView = c;
            this.realtorView = r;
        }

        public void showCustomerView() {
            mainView.Hide();
            customerView.Visible = true;
        }

        public void showMainView() {
            customerView.Hide();
            mainView.Show();
        }

        public void showRealtorView() {
            mainView.Hide();
            realtorView.Show();
        }
    }
}
