using System.Collections.Generic;
using System.Threading.Tasks;
using Sfa.Das.Sas.Indexer.ApplicationServices.Queue;
using Sfa.Das.Sas.Indexer.ApplicationServices.Services;

namespace Sfa.Das.Sas.Indexer.AzureWorkerRole
{
    public class IndexerJob : IIndexerJob
    {
        private readonly IGenericControlQueueConsumer _controlQueueConsumer;

        public IndexerJob(IGenericControlQueueConsumer controlQueueConsumer)
        {
            _controlQueueConsumer = controlQueueConsumer;
        }

        public void Run()
        {
            var tasks = new List<Task>
            {
                _controlQueueConsumer.CheckMessage<IMaintainApprenticeshipIndex>(),
                _controlQueueConsumer.CheckMessage<IMaintainProviderIndex>()
            };

            Task.WaitAll(tasks.ToArray());
        }
    }
}