## EShopMicroservices

**Catalog Microservice**
| Method  | Request URI | Use Cases |
| ------------- | ------------- | ------------- |
| GET  | /products  | List all products |
| GET  | /products/{id}  | Fetch a specific product |
| GET  | /products/category  | Get products by category |
| POST | /products | Create a new product |
| PUT | /products/{id} | Update a product |
| DELETE | /products/{id} | Remove a product |

Uses a vertical slice architecture
- Code is organized into feature folders, where each feature is encapsulated in a single .cs file
