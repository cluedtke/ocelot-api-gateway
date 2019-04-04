# ocelot-api-gateway

Adapted from: https://www.pogsdotnet.com/2018/08/building-simple-api-gateways-with.html

Demonstrates routing http requests using [Ocelot](https://ocelot.readthedocs.io/en/latest/).

## Testiing Routing
1. Run each project:
   ```
   dotnet run --project Authentication
   dotnet run --project Catalog
   dotnet run --project Gateway
   dotnet run --project Ledger
   ```

2. Test each API gateway route defined in `ocelot.json`:
   - Users Endpoint .. http://localhost:52793/api/users
   - Products Endpoint .. http://localhost:52793/api/products
   - Transactions Endpoint .. http://localhost:52793/api/transactions