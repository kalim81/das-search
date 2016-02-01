using System.Net;
using System.Reflection;
using System.Threading;
using log4net;
using Microsoft.WindowsAzure.ServiceRuntime;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Consumers;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.DependencyResolution;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Helpers;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent _runCompleteEvent = new ManualResetEvent(false);
        private IIndexerScheduler _scheduler;
        private IStandardControlQueueConsumer _standardControlQueueConsumer;

        public override void Run()
        {
            Log.Info("Starting indexer...");
            _scheduler.Schedule(() => _standardControlQueueConsumer.CheckMessage(), 10);
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;
            Initialise();

            // For information on handling configuration changes see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.
            var result = base.OnStart();

            Log.Info("Started...");

            return result;
        }

        public override void OnStop()
        {
            Log.Info("Stopping...");

            _cancellationTokenSource.Cancel();
            _runCompleteEvent.WaitOne();

            base.OnStop();

            Log.Info("Stopped...");
        }

        private void Initialise()
        {
            var container = IoC.Initialize();
            _standardControlQueueConsumer = container.GetInstance<IStandardControlQueueConsumer>();
            _scheduler = container.GetInstance<IIndexerScheduler>();
        }
    }
}