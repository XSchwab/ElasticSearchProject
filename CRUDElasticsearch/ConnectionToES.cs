using Nest;
using Elasticsearch.Net;
using System;

namespace CRUDElasticsearch
{
    class ConnectionToES
    {
        #region Connection string to connect with Elasticsearch

        public static ElasticClient EsClient()
        {
            ConnectionSettings connectionSettings;
            ElasticClient elasticClient;
            StaticConnectionPool connectionPool;

           
            
            var nodes = new Uri[]
            {
                new Uri("http://localhost:9200/"),
            };

            connectionPool = new StaticConnectionPool(nodes);
            connectionSettings = new ConnectionSettings(connectionPool);
            elasticClient = new ElasticClient(connectionSettings);

            return elasticClient;
        }

        #endregion Connection string to connect with Elasticsearch
    }
}
