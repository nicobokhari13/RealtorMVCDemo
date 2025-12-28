namespace MVCDemo {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Create Database
            HouseDatabase HouseDatabase = new HouseDatabase();
            HouseDatabase.addHouse(new HouseModel(1300.0, "22700 Blah Street", "Dearborn", "48124", "condo", 1960, 2));
            HouseDatabase.addHouse(new HouseModel(7391.0, "2270 Cherry Road", "Canton", "48187", "house", 2005, 4));
            // Create Views
            MainView mainView = new MainView();
            CustomerView customerView = new CustomerView();
            RealtorView realtorView = new RealtorView();
            HouseView houseView = new HouseView();
            // Create controllers with the Views
            MainController mainController = new MainController(mainView, customerView, realtorView);
            CustomerController customerController = new CustomerController(mainView, customerView, houseView, HouseDatabase);
            RealtorController realtorController = new RealtorController(mainView, realtorView, HouseDatabase);
            //set View's controllers
            mainView.setMainController(mainController);
            customerView.setCustomerController(customerController);
            realtorView.setRealtorController(realtorController);
            houseView.setCustomerViewController(customerController);
            //set View's information from Model
            customerView.setUpSearchResultsList();
            //Run MainView
            Application.Run(mainController.mainView);
        }
    }
}