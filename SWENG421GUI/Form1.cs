using SWENG421GUI.States;
using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWENG421GUI
{
    public partial class Form1 : Form
    {
        //Create states
        //This is one solution to not creating a new state on every state change
        //Instead objects point to one of the states
        public NeedRoute needRouteState = new NeedRoute(); //0
        public RouteNotAssigned routeNotAssignedState = new RouteNotAssigned(); //1
        public WaitingInWarehouse waitingInWarehouseState = new WaitingInWarehouse(); //2
        public InTransit inTransitState = new InTransit(); //3
        public Delivered deliveredState = new Delivered(); //4
        public OrderCompleted orderCompletedState = new OrderCompleted(); //5
        public List<State> stateList = new List<State>();

        List<Route> routesList = new List<Route>();
        List<Order> ordersList = new List<Order>();

        public Random r = new Random();
        List<ShippingObjectIF> packagesToAssign;
        List<Order> ordersToAssign = new List<Order>();
        List<Route> routesToAssign = new List<Route>();
        List<Vehicle> vehicleList = new List<Vehicle>();
        Crate c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20;

        Barrel br1, br2, br3, br4, br5, br6, br7, br8, br9, br10, br11, br12, br13, br14, br15;

        Box bx1, bx2, bx3, bx4, bx5;
        Pallet p1, p2, p3, p4, p5;
        VehicleFactory vf = new VehicleFactory();
        RoadVehicle Truck1, Truck2;
        Train Train1, Train2, Train3;

        //GUI data stuff
        BindingSource companyBinding;
        BindingSource vehicleBinding;
        BindingSource routeBinding;
        BindingSource orderBinding;
        int selectedVehicle = 0;
        int selectedRoute = 0;
        int selectedOrder = 0;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e) {
            //Binding sources used for GUI
            vehicleBinding = new BindingSource();
            companyBinding = new BindingSource();
            routeBinding = new BindingSource();
            orderBinding = new BindingSource();

            //State list init
            //Used to pass to list of states to methods
            stateList.Add(needRouteState);
            stateList.Add(routeNotAssignedState);
            stateList.Add(waitingInWarehouseState);
            stateList.Add(inTransitState);
            stateList.Add(deliveredState);
            stateList.Add(orderCompletedState);

            //Create Packages
            c1 = new Crate("Crate 1");
            c2 = new Crate("Crate 2");
            c3 = new Crate("Crate 3");
            c4 = new Crate("Crate 4");
            c5 = new Crate("Crate 5");
            c6 = new Crate("Crate 6");
            c7 = new Crate("Crate 7");
            c8 = new Crate("Crate 8");
            c9 = new Crate("Crate 9");
            c10 = new Crate("Crate 10");
            c11 = new Crate("Crate 11");
            c12 = new Crate("Crate 12");
            c13 = new Crate("Crate 13");
            c14 = new Crate("Crate 14");
            c15 = new Crate("Crate 15");
            c16 = new Crate("Crate 16");
            c17 = new Crate("Crate 17");
            c18 = new Crate("Crate 18");
            c19 = new Crate("Crate 19");
            c20 = new Crate("Crate 20");

            br1 = new Barrel("Barrel 1");
            br2 = new Barrel("Barrel 2");
            br3 = new Barrel("Barrel 3");
            br4 = new Barrel("Barrel 4");
            br5 = new Barrel("Barrel 5");
            br6 = new Barrel("Barrel 6");
            br7 = new Barrel("Barrel 7");
            br8 = new Barrel("Barrel 8");
            br9 = new Barrel("Barrel 9");
            br10 = new Barrel("Barrel 10");
            br11 = new Barrel("Barrel 11");
            br12 = new Barrel("Barrel 12");
            br13 = new Barrel("Barrel 13");
            br14 = new Barrel("Barrel 14");
            br15 = new Barrel("Barrel 15");

            bx1 = new Box("Box 1");
            bx2 = new Box("Box 2");
            bx3 = new Box("Box 3");
            bx4 = new Box("Box 4");
            bx5 = new Box("Box 5");

            p1 = new Pallet("Pallet 1", bx1);
            p2 = new Pallet("Pallet 2", bx2);
            p3 = new Pallet("Pallet 3", bx3);
            p4 = new Pallet("Pallet 4", bx4);
            p5 = new Pallet("Pallet 5", bx5);

            packagesToAssign = new List<ShippingObjectIF> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,
                                                            c11, c12, c13, c14, c15, c16, c17, c18, c19,
                                                            c20, br1, br2, br3, br4, br5, br6, br7, br8,
                                                            br9, br10, br11, br12, br13, br14, br15, p1,
                                                            p2, p3, p4, p5};
            //Create Orders
            initOrders(packagesToAssign, ordersToAssign);

            //Create Routes
            initRoutes(ordersToAssign, routesToAssign);

            //Test that packages, orders, and routes were created successfully
            //for (int i = 0; i < routesToAssign.Count; i++)
            //{
            //    Console.WriteLine("Route {0}", i);
            //    for (int j = 0; j < routesToAssign[i].toSend.Count; j++)
            //    {
            //        Console.WriteLine("Package {0}: {1}", j, routesToAssign[i].toSend[j].trackingNumber);
            //    }
            //}

            //Create Vehicles

            Truck1 = (RoadVehicle)vf.createVehicle("Truck");
            Truck2 = (RoadVehicle)vf.createVehicle("Truck");
            Train1 = (Train)vf.createVehicle("Train");
            Train2 = (Train)vf.createVehicle("Train");
            Train3 = (Train)vf.createVehicle("Train");

            Truck1.identifier = "Truck 1";
            Truck1.loadCount = 5;
            Truck1.mpg = 15.0;
            Truck1.todo = null;
            Truck1.license = "B";

            Truck2.identifier = "Truck 2";
            Truck2.loadCount = 10;
            Truck2.mpg = 10.0;
            Truck2.todo = null;
            Truck2.license = "A";

            Train1.identifier = "Train 1";
            Train1.loadCount = 15;
            Train1.mpg = 30.0;
            Train1.todo = null;
            Train1.gauge = "Standard";

            Train2.identifier = "Train 2";
            Train2.loadCount = 15;
            Train2.mpg = 35.0;
            Train2.todo = null;
            Train2.gauge = "Standard";

            Train3.identifier = "Train 3";
            Train3.loadCount = 15;
            Train3.mpg = 50.0;
            Train3.todo = null;
            Train3.gauge = "Narrow";

            vehicleList.Add(Truck1);
            vehicleList.Add(Truck2);
            vehicleList.Add(Train1);
            vehicleList.Add(Train2);
            vehicleList.Add(Train3);

            //Create Company
            Company myCompany = new Company("Shipping Co");
            myCompany.vehicles = vehicleList;
            myCompany.routesToAssign = routesToAssign;
            
            //Might not be needed but these lists are in case the originals get modified
            //They show all entries even if some get deleted
            routesList = routesToAssign;
            ordersList = ordersToAssign;

            //Creating Threads
            //Right now the thread's methods take a rich text box as a parameter so they can write to it
            //Might have to change the thread methods
            Thread companyThread = new Thread(() => myCompany.CompanyThread(OutputTextBox, stateList));
            Thread vehicleThread1 = new Thread(() => Truck1.VehicleThread(OutputTextBox, stateList));
            Thread vehicleThread2 = new Thread(() => Truck2.VehicleThread(OutputTextBox, stateList));
            Thread vehicleThread3 = new Thread(() => Train1.VehicleThread(OutputTextBox, stateList));
            Thread vehicleThread4 = new Thread(() => Train2.VehicleThread(OutputTextBox, stateList));
            Thread vehicleThread5 = new Thread(() => Train3.VehicleThread(OutputTextBox, stateList));

            //Setting the bindings to lists of objects
            vehicleBinding.DataSource = vehicleList;
            companyBinding.DataSource = vehicleList;
            routeBinding.DataSource = routesList;
            orderBinding.DataSource = ordersList;
            //ComboBox Selection
            selectedVehicle = 0;
            selectedRoute = 0;
            selectedOrder = 0;
            //Routes Packages List formats the packages in the selected route
            //Have name of parcel, tracking number, current state all as 1 string
            List<string> routePackagesList = new List<string>();
            routePackagesList = updateRoutePackageList(routesList, selectedRoute);


            //Company Tab
            CompanyNameOutput.Text = myCompany.companyName;
            CompanyVehicles.DataSource = companyBinding;
            VehicleComboBox.DisplayMember = "identifier";

            //Vehicle Tab
            VehicleComboBox.DataSource = vehicleBinding;
            VehicleComboBox.DisplayMember = "identifier";
            LoadCountOutput.Text = vehicleList[selectedVehicle].loadCount.ToString();
            MpgOutput.Text = vehicleList[selectedVehicle].mpg.ToString();
            TodoList.DataSource = vehicleList[selectedVehicle].todo;

            //Routes Tab
            RouteComboBox.DataSource = routeBinding;
            RouteComboBox.DisplayMember = "name";
            AssignedOutput.Text = routesList[selectedRoute].assigned.ToString();
            RouteOrderList.DataSource = routePackagesList;

            //Orders Tab
            OrderComboBox.DataSource = orderBinding;
            OrderComboBox.DisplayMember = "trackingNumber";
            OriginOutput.Text = ordersList[selectedOrder].originAddress;
            DestinationOutput.Text = ordersList[selectedOrder].destinationAddress;
            SenderOutput.Text = ordersList[selectedOrder].senderName;
            ReceiverOutput.Text = ordersList[selectedOrder].receiverName;
            ParcelOutput.Text = ordersList[selectedOrder].parcel.name;
            CurrentStateOutput.Text = ordersList[selectedOrder].getState().getStateName();

            //Start Threads
            companyThread.Start();
            //vehicleThread1.Start();
            //vehicleThread2.Start();
            //vehicleThread3.Start();
            //vehicleThread4.Start();
            //vehicleThread5.Start();

        }

        //Create a list of strings and format the package data for a selected route
        private List<string> updateRoutePackageList(List<Route> routeList, int selectedRoute)
        {
            List<string> ans = new List<string>();
            Order currentOrder;
            for (int i = 0; i < routeList[selectedRoute].toSend.Count; i++)
            {
                currentOrder = routeList[selectedRoute].toSend[i];
                ans.Add("Package: " + currentOrder.trackingNumber + " State: " + currentOrder.getState().getStateName());
            }
            return ans;
        }

        //Create Orders with randomly generated data
        //Note: Tracking numbers could be the same but it is unlikely
        private void initOrders(List<ShippingObjectIF> packagesToAssign, List<Order> ordersToAssign)
        {
            Order currentOrder;
            Random r = new Random();
            string trackingNum;
            string startAddress;
            string finishAddress;
            string startName;
            string endName;
            for (int i = 0; i < packagesToAssign.Count; i++)
            {
                trackingNum = r.Next(0, 999).ToString("000");
                startAddress = genAddress();
                finishAddress = genAddress();
                startName = genName();
                endName = genName();

                currentOrder = new Order(trackingNum, startAddress, finishAddress, startName, endName, packagesToAssign[i]);
                ordersToAssign.Add(currentOrder);
            }
        }

        //Generate random first name and last name based on a list and random number
        private string genName()
        {
            string ans = "";
            int select;
            string[] firstNames = { "Joe", "John", "Robert", "Michael", "David", "Joseph", "Thomas",
                                    "Mary", "Susan", "Sara", "Leah", "Jessica", "Donna", "Ashley"};
            string[] lastNames = { "Smith", "Johnson", "Williams", "Lee", "Anderson", "Jones", "Miller",
                                    "Davis", "Moore", "Martin", "Thompson", "Harris", "Robinson", "Walker" };

            select = r.Next(0, firstNames.Length - 1);
            ans += firstNames[select] + " ";
            select = r.Next(0, lastNames.Length - 1);
            ans += lastNames[select];
            return ans;
        }

        //Generate address based on a random number, random street name, and random street type like
        //street, road, lane, etc.
        private string genAddress()
        {
            string ans = "";

            string num = r.Next(1, 999).ToString("000");
            ans += num + " ";

            int select;
            string[] names = { "First", "Second", "Water", "Pine", "Mill", "Canal", "North", "South", "East", "West" };
            string[] title = { "St", "Ave", "Blvd", "Rd", "Ln" };

            select = r.Next(0, names.Length - 1);
            ans += names[select] + " ";

            select = r.Next(0, title.Length - 1);
            ans += title[select];

            return ans;
        }

        //Create routes by grouping up to 5 packages together
        private void initRoutes(List<Order> ordersToAssign, List<Route> routesToAssign)
        {
            Route currentRoute;
            int routeIndex = 1;
            for (int i = 0; i < ordersToAssign.Count; i += 5)
            {
                //Create Route with next 5 packages;
                currentRoute = new Route("Route " + routeIndex.ToString());
                currentRoute.toSend.Add(ordersToAssign[i]);
                routeIndex++;
                //Check that the next 4 are not out of range and assign them
                if (i + 1 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 1]);
                }
                if (i + 2 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 2]);
                }
                if (i + 3 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 3]);
                }
                if (i + 4 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 4]);
                }

                for (int j = 0; j < currentRoute.toSend.Count; j++) {
                    currentRoute.toSend[j].setState(routeNotAssignedState);
                }

                //Add route
                routesToAssign.Add(currentRoute);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Routes Tab
            RouteOrderList.DataSource = updateRoutePackageList(routesToAssign, selectedRoute);

            //Orders Tab
            State currentState;
            for (int i = 0; i < ordersToAssign.Count; i++) {
                currentState = ordersToAssign[i].getState();
                if (ordersList[i].getState() != currentState) {
                    ordersList[i].setState(currentState);
                }
            }
            CurrentStateOutput.Text = ordersList[selectedOrder].getState().getStateName();
        }
    }
}
