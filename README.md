# Run app
```
dos2unix docker_task-api.sh
chmod +x docker_task-api.sh
./docker_task-api.sh
```
# Install dotnet server
```
sudo add-apt-repository ppa:dotnet/backports

sudo apt-get update && \ sudo apt-get install -y dotnet-sdk-9.0
```

# Run server command
```
dotnet dev-certs https --clean
dotnet dev-certs https -ep cert.pfx -p StrongPassword123
dotnet dev-certs https --trust
```
 
 copy to folder /volumes/pizishu-asp/certs