# .NET Core API + Three Layer Architecture + Entity Framework + SQL Server + Docker-Compose

This is a project I constructed to learn .NET Core and practice the Three Layer Architecture on this technology.

## How to use ?

```sh
docker-compose up
```

Wait until the container "sql_server_api_app" print the message "Now listening on: http://0.0.0.0:5000" (it can take some time). Then access http://localhost:5000/swagger.

You may need to change the Dockerfile to be able to edit the code from your editor.

Search for the line `RUN usermod -u 1001 www-data` and change 1001 ranging from 1000 to 1005 to see if you will be able to edit the files.
