using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CoWIN_Slot_Searcher
{
    public delegate void UpdateAndNotifyResultDelegate(SlotDetails slotDetails);

    public delegate void SendMessageDelegate(string message);

    public partial class Form1 : Form
    {
        /// <summary>
        /// Holds Slot details from CoWIN server
        /// </summary>
        SlotDetails slotDetails = null;

        /// <summary>
        /// Holds the state details
        /// </summary>
        StateDetails stateDetails = null;

        /// <summary>
        /// Holds the district details
        /// </summary>
        DistrictDetails districtDetails = null;

        /// <summary>
        /// Rpresents app exit
        /// </summary>
        bool isExiting = false;

        /// <summary>
        /// Holds current district code
        /// </summary>
        string currentDistrict = string.Empty;

        /// <summary>
        /// Holds current date
        /// </summary>
        string date = string.Empty;

        /// <summary>
        /// Represents searching interval
        /// </summary>
        int searchInterval = 0;

        /// <summary>
        /// Search thread
        /// </summary>
        Thread searchThread = null;

        /// <summary>
        /// Wait event
        /// </summary>
        AutoResetEvent searchIntervalEvent = new AutoResetEvent(false);

        /// <summary>
        /// Represents searching or not
        /// </summary>
        bool isSearching = false;

        /// <summary>
        /// Sync object
        /// </summary>
        object lockObject = new object();

        public Form1()
        {
            InitializeComponent();
            this.comboBoxInterval.SelectedIndex = 0;
            this.timer1.Start();

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //Populate the state details
            PopulateStateDetails();
        }

        private void buttonSearchSlot_Click(object sender, EventArgs e)
        {
            if (buttonQuickSearch.Text.Equals("Start Continuous Search"))
            {
                UpdateSearchParams();
                searchIntervalEvent.Reset();
                isSearching = true;
                buttonQuickSearch.Text = "Stop Searching";
                buttonQuickSearch.BackColor = Color.PaleVioletRed;
            }
            else
            {
                isSearching = false;
                buttonQuickSearch.Text = "Start Continuous Search";
                searchIntervalEvent.Set();
                buttonQuickSearch.BackColor = Color.MediumSpringGreen;
            }
        }

        /// <summary>
        /// Updates the current search parameters
        /// </summary>
        private void UpdateSearchParams()
        {
            currentDistrict = GetDistrictCode();
            date = GetDate();
            searchInterval = GetSearchInterval();
        }


        private void SlotSearchThread()
        {
            do
            {
                if (isSearching)
                {
                    slotDetails = CoWINApiExecuter.GetSlotDetails(currentDistrict, date);
                    if (slotDetails != null)
                    {
                        UpdateAndNotifyResultDelegate notifyResultDelegate = new UpdateAndNotifyResultDelegate(OnUpdateAndNotifyResult);


                        notifyResultDelegate.BeginInvoke(slotDetails, null, null);
                    }
                    searchIntervalEvent.WaitOne(searchInterval);
                }
                
            }
            while (!isExiting);
        }

        /// <summary>
        /// Update the search details and notify the available slots
        /// </summary>
        /// <param name="slotDetails"></param>
        private void OnUpdateAndNotifyResult(SlotDetails slotDetails)
        {
            populateDetailsToDataGrid(slotDetails);

            ValidateAndNotifyResult(slotDetails);
        }

        /// <summary>
        /// Populates the search result to cowin portal
        /// </summary>
        /// <param name="slotDetails"></param>
        private void populateDetailsToDataGrid(SlotDetails slotDetails)
        {
            if (slotDetails != null)
            {
                if (dataGridView1.InvokeRequired)
                {
                    UpdateAndNotifyResultDelegate notifyResultDelegate = new UpdateAndNotifyResultDelegate(populateDetailsToDataGrid);
                    this.Invoke(notifyResultDelegate, slotDetails);
                }
                else
                {
                   
                    dataGridView1.Rows.Clear();
                    UpdateSessionHeaderText();

                    int index = 0;
                    int totalAvailableCapacity = 0;
                    foreach (Center center in slotDetails.centers)
                    {

                        dataGridView1.Rows.Add(center.name, center.address, center.pincode);
                        foreach(Session session in center.sessions)
                        {
                            try
                            {
                                dataGridView1.Rows[index].Cells[session.date].Value = session.vaccine + "\nTotal: "+ session .available_capacity + "\n Dose-1: " + session.available_capacity_dose1 + "\n Dose-2: " + session.available_capacity_dose2;
                                totalAvailableCapacity += (int)session.available_capacity;
                                if ((int)session.available_capacity > 0)
                                {
                                    dataGridView1.Rows[index].Cells[session.date].Style.BackColor = Color.LightGreen; ;
                                }
                            }
                            catch(Exception ex)
                            {

                            }

                        }
                        index++;
                    }

                    //Update search details
                    string searchDetals = "";
                    if (slotDetails.centers.Count > 0)
                    {
                        searchDetals = "District: " + slotDetails.centers[0].district_name;
                    }
                    else
                    {
                        searchDetals = "Slot details are not available for seleted discrict!!!";
                    }
                    labelSearchStatus.Text = searchDetals + ", Total available slots = " + totalAvailableCapacity.ToString();
                    labelLastUpdatedTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                }

            }
        }

        /// <summary>
        /// Updates the header test of vaccination days
        /// </summary>
        private void UpdateSessionHeaderText()
        {
            //Add date to 4 days from selected date
            string columnHeaderText = date;
            for (int i = 3; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = columnHeaderText;
                dataGridView1.Columns[i].Name = columnHeaderText;

                DateTime nextDate = dateTimePicker1.Value.AddDays(i-2);
                columnHeaderText = nextDate.ToString("dd-MM-yyyy");
            }

        }

        /// <summary>
        /// Get the disctrict code for cowin portal
        /// </summary>
        /// <returns>District code</returns>
        private string GetDistrictCode()
        {
            string distCode = string.Empty;
            if (comboBoxDistricts.SelectedItem != null && districtDetails != null)
            {
                distCode = districtDetails.districts.First(item => item.district_name == comboBoxDistricts.SelectedItem.ToString()).district_id.ToString();
            }
            return distCode;
        }

        /// <summary>
        /// Gets the search interval
        /// </summary>
        /// <returns></returns>
        private int GetSearchInterval()
        {
            int searchInterval = 0;
            if (comboBoxInterval.SelectedItem == null)
            {
                return 0;
            }
            switch (comboBoxInterval.SelectedItem.ToString())
            {
                case "10 Sec":
                    searchInterval = 1000 * 10;
                    break;

                case "30 Sec":
                    searchInterval = 1000 * 30;
                    break;

                case "1 Min":
                    searchInterval = 1000 * 60 * 1;
                    break;

                case "5 Min":
                    searchInterval = 1000 * 60 * 5;
                    break;

                case "10 Min":
                    searchInterval = 1000 * 60 * 10;
                    break;

                case "15 Min":
                    searchInterval = 1000 * 60 * 15;
                    break;

                case "30 Min":
                    searchInterval = 1000 * 60 * 30;
                    break;

                default:
                    searchInterval = 1000 * 60 * 1;
                    break;
            }

            return searchInterval;
        }

        /// <summary>
        /// Get the date in specified format for cowin portal
        /// </summary>
        /// <returns>Date</returns>
        private string GetDate()
        {
            string selectedDate = "00-00-0000";
            selectedDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            return selectedDate;
        }

        /// <summary>
        /// Timer to display current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCurrrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        /// <summary>
        /// Starts the search thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            searchThread = new Thread(new ThreadStart(SlotSearchThread));
            searchThread.Start();
        }

        /// <summary>
        /// Form close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isSearching = false;
            searchIntervalEvent.Set();
            isExiting = true;
        }

        /// <summary>
        /// Updates the serach properties
        /// </summary>
        private void OnSearchPropertiesChanged(object sender, EventArgs e)
        {
            UpdateSearchParams();
            slotDetails = CoWINApiExecuter.GetSlotDetails(currentDistrict, date);
            if (slotDetails != null)
            {
                UpdateAndNotifyResultDelegate notifyResultDelegate = new UpdateAndNotifyResultDelegate(OnUpdateAndNotifyResult);
                notifyResultDelegate.BeginInvoke(slotDetails, null, null);
            }
        }

        /// <summary>
        /// Gets the state details from CoWIN portal
        /// </summary>
        private void PopulateStateDetails()
        {
           stateDetails =  CoWINApiExecuter.GetStateDetails();
            if (stateDetails != null && stateDetails.states.Count > 0)
            {
                foreach (State state in stateDetails.states)
                {
                    comboBoxStates.Items.Add(state.state_name);
                    
                }
                comboBoxStates.SelectedIndex = 17;
            }
        }

        /// <summary>
        /// On selected item of States combobox xhanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStates.SelectedItem != null && stateDetails != null)
            {
                string stateCode = stateDetails.states.First(item => item.state_name == comboBoxStates.SelectedItem.ToString()).state_id.ToString();
                districtDetails = CoWINApiExecuter.GetDistrictDetails(stateCode);
                if (districtDetails != null && districtDetails.districts.Count > 0)
                {
                    comboBoxDistricts.Items.Clear();
                    foreach (District district in districtDetails.districts)
                    {
                        comboBoxDistricts.Items.Add(district.district_name);
                    }
                    comboBoxDistricts.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Validates and notify the user about result
        /// </summary>
        /// <param name="slotDetails"></param>
        private void ValidateAndNotifyResult(SlotDetails slotDetails)
        {
            if (slotDetails != null)
            {
                int searchPIN = Convert.ToInt32(textBoxNotifyPinCode.Text);

                foreach (Center center in slotDetails.centers)
                {
                    string message = string.Empty;

                    //Validate the search PIN code
                    //If 0 , do not validate pin code
                    if (searchPIN > 0 && Convert.ToInt32(center.pincode) != searchPIN)
                    {
                        break;
                    }

                    foreach (Session session in center.sessions)
                    {
                        //Validate min number of available slots to notify
                        if (session.available_capacity > Convert.ToInt32(textBoxAvailableSlotLimit.Text))
                        {
                            message = $"Vaccination slots available, Center: {center.name}, Address: {center.address}, Available slots {session.available_capacity}";
                            break;
                        }
                    }

                    if (message.Length > 0)
                    {
                        SendMessageDelegate messageDelegate = new SendMessageDelegate(SendNotification);
                        messageDelegate.BeginInvoke(message, null, null);
                    }                    
                }
            }
        }

        /// <summary>
        /// Send the notification message
        /// </summary>
        /// <param name="message"></param>
        private void SendNotification(string message)
        {
            lock (lockObject)
            {
                try
                {
                    if (checkBoxNotifyMessage.Checked)
                    {
                        TelegramNotifier.SendTelegramMessage(message);
                    }

                    if (checkBoxNotifyAlarm.Checked)
                    {
                        Console.Beep(1000, 5000);
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }
    }
}
