using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;

namespace uwpApplicationBase
{
    class IdentityChecker
    {
        public static bool SampleIdentityConfigurationCorrect(String AzureClientId = "Not applicable")
        {
            string outputMessage = "";
            bool isCorrect = true;

            if (AzureClientId == "")
            {
                outputMessage += "Azure AD Client ID not set; cannot sign in with Azure AD\n";
                isCorrect = false;
            }

            if (Package.Current.Id.Publisher == "CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US")
            {
                outputMessage += "Application identity not set; cannot sign in with Microsoft account.\n";
                isCorrect = false;
            }

            if (!isCorrect)
            {
                outputMessage += "See Readme.MD for details";                
            }
            return isCorrect;
        }
    }
}
