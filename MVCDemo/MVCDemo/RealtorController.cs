namespace MVCDemo {
    public class RealtorController {

        private Form mainView; // only used for navigation
        private Form realtorView; //used to update information on this view
        private HouseDatabase houseDatabase;

        public RealtorController(MainView m, RealtorView r, HouseDatabase d) {
            mainView = m;
            realtorView = r;
            houseDatabase = d;
        }

        public void showMainView() {
            realtorView.Hide();
            mainView.Show();
        }

    }
}
