using SWENG421GUI.States;
using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public List<Type> types = new List<Type>();
        public List<Type> vehicleTypes = new List<Type>();

        List<Route> routesList = new List<Route>();
        List<Order> ordersList = new List<Order>();
        List<string> parcelList = new List<string>();

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
        Company myCompany;
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
            for (int i = 0; i < routesToAssign.Count; i++)
            {
                Console.WriteLine("Route {0}", i);
                for (int j = 0; j < routesToAssign[i].toSend.Count; j++)
                {
                    Console.WriteLine("Package {0}: {1}", j, routesToAssign[i].toSend[j].parcel.name);
                }
            }

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
            myCompany = new Company("Shipping Co");
            myCompany.vehicles = vehicleList;
            myCompany.routesToAssign = routesToAssign;

            // Loading loadable classes
            Vehicle loadedVehicle = myCompany.addVehicle("SWENG421GUI.Loadable.Vehicles.Drone");
            loadedVehicle.identifier = loadedVehicle.GetType().Name + " 1";
            loadedVehicle.loadCount = 5;
            loadedVehicle.mpg = 10;
            loadedVehicle.todo = null;
            loadedVehicle.setAttribute("15");
            vehicleList.Add(loadedVehicle);
            myCompany.vehicles = vehicleList;


            //Might not be needed but these lists are in case the originals get modified
            //They show all entries even if some get deleted
            routesList = routesToAssign;
            ordersList = ordersToAssign;

            //Creating Threads
            //Right now the thread's methods take a rich text box as a parameter so they can write to it
            //Might have to change the thread methods
            Thread companyThread = new Thread(() => myCompany.CompanyThread(this, stateList));

            //Create vehicle threads dynamically, supports dynamic linkage
            //Vehicle and its thread added to dictionary, and can be called to start later on
            //Count shouldn't be -1 in final version
            //Dictionary<Vehicle, Thread> vehicleThreadDict = new Dictionary<Vehicle, Thread>();
            //for (int i = 0; i < vehicleList.Count; i++) {
            //    Console.WriteLine("Adding Thread For: " + vehicleList[i].identifier);
            //    vehicleThreadDict.Add(vehicleList[i], new Thread(() => vehicleList[i].VehicleThread(this, stateList)));
            //}
            
            //Old thread creation:
            Thread vehicleThread1 = new Thread(() => Truck1.VehicleThread(this, stateList));
            Thread vehicleThread2 = new Thread(() => Truck2.VehicleThread(this, stateList));
            Thread vehicleThread3 = new Thread(() => Train1.VehicleThread(this, stateList));
            Thread vehicleThread4 = new Thread(() => Train2.VehicleThread(this, stateList));
            Thread vehicleThread5 = new Thread(() => Train3.VehicleThread(this, stateList));
            Thread vehicleThread6 = new Thread(() => vehicleList[vehicleList.Count-1].VehicleThread(this, stateList));

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
            parcelList = updateParcelList(vehicleList, selectedVehicle);
            TodoList.DataSource = parcelList;

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
            CurrentStateOutput.Text = ordersList[selectedOrder].getState(this).getStateName();

            //Manage Tab
            types.Add(typeof(ShippingObjectIF));
            types.Add(typeof(Order));
            types.Add(typeof(Route));
            types.Add(typeof(Vehicle));
            List<string> options = new List<string>();
            foreach (Type t in types)
            {
                options.Add(t.Name);
            }
            AddObjectBox.DataSource = options;

            //Start Threads
            companyThread.Start();

            //Start unknown number of vehicle threads called by unknown vehicle objects
            //for (int i = 0; i < vehicleList.Count; i++) {
            //    Console.WriteLine("Starting Thread of: " + vehicleList[i].identifier);
            //    vehicleThreadDict[vehicleList[i]].Start();
            //}
            
            vehicleThread1.Start();
            vehicleThread2.Start();
            vehicleThread3.Start();
            vehicleThread4.Start();
            vehicleThread5.Start();
            vehicleThread6.Start();
        }

        //Create a list of strings and format the package data for a selected route
        private List<string> updateRoutePackageList(List<Route> routeList, int selectedRoute)
        {
            List<string> ans = new List<string>();
            Order currentOrder;
            for (int i = 0; i < routeList[selectedRoute].toSend.Count; i++)
            {
                currentOrder = routeList[selectedRoute].toSend[i];
                ans.Add("Package: " + currentOrder.trackingNumber + " State: " + currentOrder.getState(this).getStateName());
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

                currentOrder = new Order(trackingNum, startAddress, finishAddress, startName, endName, packagesToAssign[i], this);
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
                    currentRoute.toSend[j].setState(routeNotAssignedState, this);
                }

                //Add route
                routesToAssign.Add(currentRoute);
            }

        }

        //Every second update the GUI's values
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vehicles Tab
            parcelList = updateParcelList(vehicleList, selectedVehicle);
            TodoList.DataSource = parcelList;

            //Routes Tab
            RouteOrderList.DataSource = updateRoutePackageList(routesToAssign, selectedRoute);
            AssignedOutput.Text = routesToAssign[selectedRoute].assigned.ToString();

            //Orders Tab
            State currentState;
            for (int i = 0; i < ordersToAssign.Count; i++) {
                currentState = ordersToAssign[i].getState(this);
                if (ordersList[i].getState(this) != currentState) {
                    ordersList[i].setState(currentState, this);
                }
            }
            CurrentStateOutput.Text = ordersList[selectedOrder].getState(this).getStateName();
        }

        //Used to update list of packages for vehicle tab's todo list
        private List<string> updateParcelList(List<Vehicle> vlist, int select) {
            List<string> ans = new List<string>();
            if (vlist[select].todo != null)
            {
                if (vlist[select].todo.toSend != null)
                {
                    for (int i = 0; i < vlist[select].todo.toSend.Count; i++)
                    {
                        ans.Add(vlist[select].todo.toSend[i].parcel.name + " " + vlist[select].todo.toSend[i].getState(this).getStateName());
                    }
                }
            }
            return ans;
        }

        // changes color of state text
        private void CurrentStateOutput_TextChanged(object sender, EventArgs e)
        {
            if (CurrentStateOutput.Text.Equals("NeedRoute")) { CurrentStateOutput.ForeColor = Color.DarkRed; }
            if (CurrentStateOutput.Text.Equals("NotAssignedRoute")) { CurrentStateOutput.ForeColor = Color.Tomato; }
            if (CurrentStateOutput.Text.Equals("WaitingInWarehouse")) { CurrentStateOutput.ForeColor = Color.CornflowerBlue; }
            if (CurrentStateOutput.Text.Equals("InTransit")) { CurrentStateOutput.ForeColor = Color.DarkCyan; }
            if (CurrentStateOutput.Text.Equals("Delivered")) { CurrentStateOutput.ForeColor = Color.LimeGreen; }
            if (CurrentStateOutput.Text.Equals("OrderCompleted")) { CurrentStateOutput.ForeColor = Color.DarkOliveGreen; }
        }
        private void VehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCountOutput.Text = vehicleList[VehicleComboBox.SelectedIndex].loadCount.ToString();
            MpgOutput.Text = vehicleList[VehicleComboBox.SelectedIndex].mpg.ToString();
            // change route/todo listbox
            attributesbox.Text = vehicleList[VehicleComboBox.SelectedIndex].getInfo();
            selectedVehicle = VehicleComboBox.SelectedIndex;
            parcelList = updateParcelList(vehicleList, selectedVehicle);
            TodoList.DataSource = parcelList;
        }
        private void OrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OriginOutput.Text = ordersList[OrderComboBox.SelectedIndex].originAddress;
            DestinationOutput.Text = ordersList[OrderComboBox.SelectedIndex].destinationAddress;
            SenderOutput.Text = ordersList[OrderComboBox.SelectedIndex].senderName;
            ReceiverOutput.Text = ordersList[OrderComboBox.SelectedIndex].receiverName;
            ParcelOutput.Text = ordersList[OrderComboBox.SelectedIndex].parcel.name;
            CurrentStateOutput_TextChanged(sender, e);

            selectedOrder = OrderComboBox.SelectedIndex;
            State currentState;
            for (int i = 0; i < ordersToAssign.Count; i++)
            {
                currentState = ordersToAssign[i].getState(this);
                if (ordersList[i].getState(this) != currentState)
                {
                    ordersList[i].setState(currentState, this);
                }
            }
            CurrentStateOutput.Text = ordersList[selectedOrder].getState(this).getStateName();

        }
        private void RouteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssignedOutput.Text = routesList[RouteComboBox.SelectedIndex].assigned.ToString();
            // change orders listbox
            selectedRoute = RouteComboBox.SelectedIndex;
            RouteOrderList.DataSource = updateRoutePackageList(routesToAssign, selectedRoute);
            AssignedOutput.Text = routesToAssign[selectedRoute].assigned.ToString();
        }

        public void updateOutputPanel(string toAdd) {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(updateOutputPanel), new object[] { toAdd });
                return;
            }

            //this.OutputTextBox.Text += toAdd;
            this.OutputTextBox.AppendText(toAdd);

            //Output panel scroll
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;
            OutputTextBox.ScrollToCaret();
        }

        // GUI lists for adding and populating
        List<Type> loadableTypes = new List<Type>();
        List<Type> palletableTypes = new List<Type>();
        List<Type> loadableSObjects = new List<Type>();
        List<Type> soTypes = new List<Type>();

        // updates combobox with loadable vehicle classes
        private void LoadableBox_CheckedChanged(object sender, EventArgs e)
        {
            AvailableVehicleTypesBox.Items.Clear();
            AvailableVehicleTypesBox.Text = "";
            if (LoadableBox.Checked) 
            {
                BuiltInBox.Enabled = false;
                foreach(Type t in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if(t.IsClass && t.Namespace.Equals("SWENG421GUI.Loadable.Vehicles")){
                        loadableTypes.Clear();
                        loadableTypes.Add(t);
                        AvailableVehicleTypesBox.Items.Add(t.Name);
                    }
                }
                AvailableVehicleTypesBox.SelectedIndex = 0;
            }
            else 
            {
                BuiltInBox.Enabled = true;
            }

        }

        // updates combobox with built in vehicle classes
        private void BuiltInBox_CheckedChanged(object sender, EventArgs e)
        {
            AvailableVehicleTypesBox.Items.Clear();
            AvailableVehicleTypesBox.Text = "";
            if (BuiltInBox.Checked)
            {
                LoadableBox.Enabled = false;
                vehicleTypes.Clear();
                vehicleTypes.Add(typeof(RoadVehicle));
                vehicleTypes.Add(typeof(Train));
                vehicleTypes.Add(typeof(Ship));
                vehicleTypes.Add(typeof(Plane));
                foreach (Type t in vehicleTypes)
                {
                    AvailableVehicleTypesBox.Items.Add(t.Name);
                }
                AvailableVehicleTypesBox.SelectedIndex = 0;
            }
            else
            {
                LoadableBox.Enabled = true;
            }
        }
    
        // gets the attribute unique to each Vehicle class and updates label accordingly
        private void AvailableVehicleTypesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type t = getSelectedTypeOfVehicle();
            MethodInfo method = t.GetMethod("getFieldInfoOnly");
            var v = Activator.CreateInstance(t) as Vehicle;
            var result = method.Invoke(v, null);
            AttributeLabel.Text = result.ToString();
        }

        // has company object add a vehicle and return the vehicle to update its attributes with user input
        private void confirmAddVehicleButton_Click(object sender, EventArgs e)
        {
            Type t = getSelectedTypeOfVehicle();
            Vehicle v = myCompany.addVehicle(t.FullName);
            VehicleAddStatusBox.Text = v.OnCreate();
            v.identifier = IdentifierBox.Text; 
            v.loadCount = int.Parse(loadCountBox.Text);
            v.mpg = double.Parse(mpgBox.Text);
            v.todo = null;
            v.setAttribute(attributeBox.Text);
            // update gui vehicle list 
            // vehicleList.Add(v);
        }

        // gets the type of vehicle selected at any given point
        public Type getSelectedTypeOfVehicle()
        {
            Type t;
            if (LoadableBox.Checked)
            {
                t = loadableTypes[AvailableVehicleTypesBox.SelectedIndex];
            }
            else
            {
                t = vehicleTypes[AvailableVehicleTypesBox.SelectedIndex];
            }
            return t;
        }

        // gets the type of shipping object selected at any given point
        public Type getSelectedTypeOfShippingObject()
        {
            Type t;
            if (loadableSObox.Checked)
            {
                t = loadableSObjects[SObox.SelectedIndex];
            }
            else
            {
                t = soTypes[SObox.SelectedIndex];
            }
            return t;
        }
 
        // updates and populates GUI based on user input
        private void SObox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(getSelectedTypeOfShippingObject().Name.Equals("Pallet"))
            {
                palletableTypes.Clear();
                palletableNameBox.Enabled = true;
                selectPalletablebox.Enabled = true;
                palletableTypes.Add(typeof(Barrel));
                palletableTypes.Add(typeof(Box));
                foreach(Type t in palletableTypes)
                {
                    selectPalletablebox.Items.Add(t.Name);
                }
                selectPalletablebox.SelectedIndex = 0;
            }
            else
            {
                palletableNameBox.Enabled = false;
                selectPalletablebox.Enabled = false;
            }

        }

        // gets and populates combobox with all loadable shipping objects
        private void loadableSObox_CheckedChanged(object sender, EventArgs e)
        {
            SObox.Items.Clear();
            SObox.Text = "";
            if (loadableSObox.Checked)
            {
                builtinSObox.Enabled = false;
                foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if (t.IsClass && t.Namespace.Equals("SWENG421GUI.Loadable.ShippingObjects"))
                    {
                        loadableSObjects.Clear();
                        loadableSObjects.Add(t);
                        SObox.Items.Add(t.Name);
                    }
                }
                SObox.SelectedIndex = 0;
            }
            else
            {
                builtinSObox.Enabled = true;
            }


        }

        // updates and populates combobox with built-in shipping object classes
        private void builtinSObox_CheckedChanged(object sender, EventArgs e)
        {
            SObox.Items.Clear();
            SObox.Text = "";
            if (builtinSObox.Checked)
            {
                loadableSObox.Enabled = false;
                soTypes.Clear();
                soTypes.Add(typeof(Crate));
                soTypes.Add(typeof(Pallet));
                foreach (Type t in soTypes)
                {
                    SObox.Items.Add(t.Name);
                }
                SObox.SelectedIndex = 0;
            }
            else
            {
                loadableSObox.Enabled = true;
            }
        }
        // if object is of loadable type, company deals with loading and instantiating it (enviroment)
        // if object is pallet, it creates a palletableif object before creating pallet
        // else, object is instantiated based on type and updated name to match user input
        private void addShippingObjectbutton_Click(object sender, EventArgs e)
        {
            Type t = getSelectedTypeOfShippingObject();
            ShippingObjectIF shippingObject;
            if (t.IsSubclassOf(typeof(AbstractLoadableShippingObject)))
            {
                shippingObject = myCompany.prepareLoadableParcel(t.FullName);
            }
            else if (t.Name.Equals("Pallet"))
            {
                Type palletType = getSelectedTypeOfPalletable();
                PalletableIF palletable = (PalletableIF)Activator.CreateInstance(palletType, palletableNameBox.Text);
                shippingObject = new Pallet(soNameBox.Text, palletable);
            }
            else
            {
                shippingObject = (ShippingObjectIF)Activator.CreateInstance(t, t.Name);
            }
            shippingObject.name = soNameBox.Text;
            addShippingObjectStatusBox.Text = shippingObject.OnCreate();
            // update packagestoassign
            packagesToAssign.Add(shippingObject);
        }
        // gets the selected type of palletable at any given time
        public Type getSelectedTypeOfPalletable()
        {
            return palletableTypes[selectPalletablebox.SelectedIndex];
        }
    }
}
