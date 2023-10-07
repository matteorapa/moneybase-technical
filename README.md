# Multi-Agent Chat Support System
### Moneybase technical task


Setup using Docker Compose.
**Required: Docker, .Net Core 7 SDK**


Run commands at the same level of the *./SupportAPI* directory. First build the images using:

`docker-compose build`

Then start the running images using:

`docker-compose up`

After this step, there will be 3 containers:
1. The Dotnet API.
2. The postgres database.
3. The RabbitMQ instance for the queue.


Apply migrations to postgres database (running on docker container).

`dotnet ef database update`


Go to the (localhost:15672) [RabbitMQ Management UI](localhost:15672)

Restart the containers, to use updated database.

`docker-compose restart`


For the purpose I did not implement authentication for brevity. One may use Json Web Tokens for stateless authentication, suitable for a scalable API.