### Building and running your application

When you're ready, start your application by running:
[ORIGINAL]
`docker compose up --build`.

[CUSTOM]
Local development:
`docker network create bookmarxnetwork`
`docker build -t your-app:1.1.0 -f {{environment}}.Dockerfile .`
`docker compose -f compose.{{environment}}.yaml up -d --no-deps`

Optional push to specific container registry:
`docker push your-registry-url/your-app:1.1.0`

Your application will be available at http://localhost:5000.

### Deploying your application to the cloud

First, build your image, e.g.: `docker build -t myapp .`.
If your cloud uses a different CPU architecture than your development
machine (e.g., you are on a Mac M1 and your cloud provider is amd64),
you'll want to build the image for that platform, e.g.:
`docker build --platform=linux/amd64 -t myapp .`.

Then, push it to your registry, e.g. `docker push myregistry.com/myapp`.

Consult Docker's [getting started](https://docs.docker.com/go/get-started-sharing/)
docs for more detail on building and pushing.

### References
* [Docker's .NET guide](https://docs.docker.com/language/dotnet/)
* The [dotnet-docker](https://github.com/dotnet/dotnet-docker/tree/main/samples)
  repository has many relevant samples and docs.

# Docker Setup
- https://aschmelyun.com/blog/what-you-should-do-before-deploying-docker-to-production/
