# Subsequence Generator
A demo application that generates the longest increasing substring given a string of numbers.

## Running the web application

### Using dotnet CLI
1. Clone the repository to a local folder.
2. Navigate to project folder and run command   
`dotnet publish -c Release`
3. Run the project using command  
`dotnet run`
4. Alternatively you can navigate to release folder  `\bin\Release\net8.0`  and run the command   
`dotnet SubsequenceService.dll`
### Using docker CLI
Note: Please make sure dockers in installed on your system.

1. Build image from docker file using command  
`docker build -t subsequence-image -f Dockerfile .`
2. Run the container using command  
`docker run docker run -it --rm subsequence-image "1 3 5 6" 


## Testing
Navigate to solution file folder and run the following command  
`dotnet test`
