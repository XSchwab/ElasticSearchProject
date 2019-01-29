# ElasticSearchProject
Our project

First, you need to download the elasticSearch binary.
You will find them at https://www.elastic.co/downloads

After that you need to launch the service:

Linux and Mac :./bin/elasticsearch

Windows :./bin/elasticsearch.bat


Finally, you need to upload the file "Account3.json" 

use this command:
curl -XPUT localhost:9200/_bulk -H"Content-Type: application/json" --data-binary @Account3.json
