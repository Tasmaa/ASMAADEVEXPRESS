using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMAADEVEXPRESS.FRM
{
    class UserSettingTemplates
    {
        int ProfileID { get; set; }
        public UserSettingTemplates(int profileId)
        {
            ProfileID = profileId;
            General = new GeneralSettings(ProfileID);
        }
        public GeneralSettings General;


        public class GeneralSettings
        {

            int ProfileID { get; set; }

            public GeneralSettings(int profileId)
            {
                ProfileID = profileId;

            }
        }
 
    public bool CanChangeStore { get; set; }
        public int DefaultRowStore { get; set; }
        public int Store { get; set; }
        public bool CanChangeDrawer { get; set; }
        public int DefaultDrawer { get; set; }
        public int DefaultCustomer { get; set; }
        public bool CanChangeCustomer { get; set; }
        public int DefaultVender { get; set; }
        public bool CanChangeVender { get; set; }
        public byte DefaultPayMethodInSales { get; set; }



    }

}

