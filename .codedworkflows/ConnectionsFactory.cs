using UiPath.CodedWorkflows;
using System;

namespace client_p001_process_name
{
    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection My_Workspace_dante_libiot_sisuadigital_com { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_dante_libiot_sisuadigital_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("79b59bfc-a47e-4433-9559-11f78e264803", resolver);
        }
    }

    public class O365MailFactory
    {
        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection My_Workspace_dante_libiot_sisuadigital_com { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_dante_libiot_sisuadigital_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("79b59bfc-a47e-4433-9559-11f78e264803", resolver);
        }
    }
}