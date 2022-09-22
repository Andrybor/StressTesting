# StressTesting
Stress Testing .net web api with POST request (which save simple data model to db) wit with Siege util.

## Siege Commands (c10, c25, c50, c100)
- siege -c10 -t60S --content-type "application/json" 'https://localhost:your_port/SimpleSaveDb POST {"Login": "andytest", "Password":"andytest"}'
- siege -c25 -t60S --content-type "application/json" 'https://localhost:your_port/SimpleSaveDb POST {"Login": "andytest", "Password":"andytest"}'
- siege -c50 -t60S --content-type "application/json" 'https://localhost:your_port/SimpleSaveDb POST {"Login": "andytest", "Password":"andytest"}'
- siege -c100 -t60S --content-type "application/json" 'https://localhost:your_port/SimpleSaveDb POST {"Login": "andytest", "Password":"andytest"}'

## Stress testing results

| Metric        |     10c     | 25c          | 50c          | 100c         |
|---------------|:-----------:|--------------|--------------|--------------|
| Availability  |  100.00 %   | 100.00 %     | 100.00 %     | 100.00 %     |
| Response time |  0.31 sec   | 1.03 sec     | 1.11 sec     | 2.15 sec     |
| Throughput    | 0.00 MB/sec | 0.00 MB/sec  | 0.00 MB/sec  | 0.00 MB/sec  |

## Prerequisites

You will need the following tools:
* [Visual Studio Code or Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (version 17.0.0 Preview 7.0 or later)
* [.NET Core SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
* MSSQL | Docker
* Siege

### Run

1. Install the latest [.NET Core 6 SDK](https://dotnet.microsoft.com/download).
2. Clone the repo
   ```sh
   git clone https://github.com/Andrybor/StressTesting.git
   ```
3. Go to Program.cs folder and put your db connection string
   ```sh
   builder.Services.AddDbContext<SiegeDbContext>(options => {
   // put your connection string here
   options.UseSqlServer("Data Source=.;\nInitial Catalog=;User ID=;TrustServerCertificate=true;Password=");
   });
   ```
4. Run command
   ```
   dotnet run --project SiegeStressTesting
   ```
5. Run Siege commands