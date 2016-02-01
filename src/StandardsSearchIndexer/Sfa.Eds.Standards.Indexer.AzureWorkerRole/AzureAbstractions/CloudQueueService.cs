﻿using Microsoft.WindowsAzure.Storage;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole.AzureAbstractions
{
    public class CloudQueueService : ICloudQueueService
    {
        public ICloudQueueWrapper GetQueueReference(string connectionString, string queueName)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();

            var queue = new CloudQueueWrapper(queueClient.GetQueueReference(queueName));
            queue.CreateIfNotExists();
            return queue;
        }
    }
}