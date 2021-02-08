docker build -t dotnet_persistencia -f Dockerfile .

docker run -it --rm -p 5000:80 --name persistencia dotnet_persistencia

