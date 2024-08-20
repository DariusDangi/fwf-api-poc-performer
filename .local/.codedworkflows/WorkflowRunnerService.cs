using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using fwfapipocperformer;

[assembly: WorkflowRunnerServiceAttribute(typeof(fwfapipocperformer.WorkflowRunnerService))]
namespace fwfapipocperformer
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/TestCase_DetermineAnimalType.xaml
        /// </summary>
        public void TestCase_DetermineAnimalType()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\TestCase_DetermineAnimalType.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the ServiceLayer/CallAnimalAPI.xaml
        /// </summary>
        public void CallAnimalAPI(string in_AnimalType, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ServiceLayer\CallAnimalAPI.xaml", new Dictionary<string, object>{{"in_AnimalType", in_AnimalType}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/TestCase_CallAnimalAPI.xaml
        /// </summary>
        public void TestCase_CallAnimalAPI()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\TestCase_CallAnimalAPI.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DataLayer/DetermineAnimalType.xaml
        /// </summary>
        public void DetermineAnimalType(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DataLayer\DetermineAnimalType.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}