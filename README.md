# Microservices Project with API Gateway (Ocelot)

This project demonstrates a microservices architecture implemented using ASP.NET and an API gateway powered by Ocelot. It includes multiple microservices, with a Catalog Service handling product-related operations.

## Project Structure

- **CatalogService**: Microservice responsible for managing products.
- **APIGateway (Ocelot)**: Centralized entry point for clients to access microservices.

## Getting Started

To run the project locally, follow these steps:

1. Clone the repository.
2. Navigate to the root directory.
3. Make sure you have the necessary prerequisites installed, including .NET SDK.
4. Run each microservice individually or use a Docker-compose setup if available.
5. Start the API gateway (Ocelot).
6. Access the endpoints through the API gateway.

## Configuration

- **Ocelot Configuration**: Define routing rules and endpoints in the `ocelot.json` file.
- **Database Connection**: Update connection strings in the `appsettings.json` files of respective microservices.

## Dependencies

- ASP.NET Core
- Ocelot
- Entity Framework Core (if using a database)
- Docker (optional)

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests for enhancements or bug fixes.

## License

This project is licensed under the [MIT License](LICENSE).
