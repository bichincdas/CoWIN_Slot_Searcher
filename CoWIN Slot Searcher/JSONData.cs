
using System.Collections.Generic;

namespace CoWIN_Slot_Searcher
{
    public class VaccineFee
    {
        public string vaccine { get; set; }
        public string fee { get; set; }
    }

    public class Session
    {
        public string session_id { get; set; }
        public string date { get; set; }
        public double available_capacity { get; set; }
        public int available_capacity_dose1 { get; set; }
        public int available_capacity_dose2 { get; set; }
        public int min_age_limit { get; set; }
        public string vaccine { get; set; }
        public List<string> slots { get; set; }
    }

    public class Center
    {
        public int center_id { get; set; }
        public string name { get; set; }
        public string name_l { get; set; }
        public string address { get; set; }
        public string address_l { get; set; }
        public string state_name { get; set; }
        public string state_name_l { get; set; }
        public string district_name { get; set; }
        public string district_name_l { get; set; }
        public string block_name { get; set; }
        public string block_name_l { get; set; }
        public string pincode { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string fee_type { get; set; }
        public List<VaccineFee> vaccine_fees { get; set; }
        public List<Session> sessions { get; set; }
    }

    public class SlotDetails
    {
        public List<Center> centers { get; set; }
    }


    public class State
    {
        public int state_id { get; set; }
        public string state_name { get; set; }
        public string state_name_l { get; set; }
    }

    public class StateDetails
    {
        public List<State> states { get; set; }
        public int ttl { get; set; }
    }

    public class District
    {
        public int state_id { get; set; }
        public int district_id { get; set; }
        public string district_name { get; set; }
        public string district_name_l { get; set; }
    }

    public class DistrictDetails
    {
        public List<District> districts { get; set; }
        public int ttl { get; set; }
    }


}
