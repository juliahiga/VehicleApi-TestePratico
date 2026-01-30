<h1 align="center" style="font-weight: bold;">CarsLib 💻</h1>

<p align="center">
 <a href="#tech">Tecnologias Obrigatórias</a> • 
 <a href="#executar">Getting Started</a> • 
  <a href="#rotas">API Endpoints</a>
</p>

<p align="center">
    <b>Uma API REST feita para realizar o cadastro e consulta de veículos.</b>
</p>

<h2 id="tecnologias">💻 Tecnologias Obrigatórias</h2>

- .NET 8
- OpenAPI (Swagger)
- ASP.NET Core Web API (Controllers)
- Entity Framework Core InMemory
- FluentValidation

<h2 id="executar">🚀 Como executar o projeto</h2>

### Clonando o repositório:
O comando abaixo é responsável por clonar o repositório:
```bash
git clone https://github.com/juliahiga/VehicleApi-TestePratico
```
Acessar a pasta do repositório:
```bash
cd VehicleApi-TestePratico
```

<h2 id="rotas">📍 Endpoints da API</h2>

<kbd>POST /api/Vehicle</kbd>     | Cadastra um novo veículo [detalhes da requisição](#post-auth-detail)

<kbd>PUT /api/Vehicle/{id}</kbd>     | Atualizar um veículo [detalhes da requisição](#put-auth-detail)

​<kbd>GET /api/Vehicle/{id}</kbd>     | Buscar veículo por ID [detalhes da requisição](#getid-auth-detail)

​<kbd>GET /api/Vehicle</kbd>     | Listar todos os veículos [detalhes da requisição](#get-auth-detail)

​<kbd>DELETE /api/Vehicle/{id}</kbd>     | Remove um veículo


<h3 id="get-auth-detail">GET /api/Vehicle/{id}</h3>

**RESPOSTA**
```json
{
  "id": "16ff5512-fc4a-41f9-9052-a45b4be42102",
  "description": "Versátil o suficiente para ser um polivalente urbano e um atleta esportivo.",
  "brand": 7,
  "model": "X1",
  "optional": "",
  "price": 0
}
```

<h3 id="get-auth-detail">GET /api/Vehicle</h3>

**RESPOSTA**
```json
[
  {
    "id": "54265acd-00a6-454a-8e19-f7b1d0c88d16",
    "description": "O hatch elétrico com melhor custo-benefício da categoria.",
    "brand": 6,
    "model": "Dolphin",
    "optional": "",
    "price": 0
  },
  {
    "id": "16ff5512-fc4a-41f9-9052-a45b4be42102",
    "description": "Versátil o suficiente para ser um polivalente urbano e um atleta esportivo.",
    "brand": 7,
    "model": "X1",
    "optional": "",
    "price": 0
  }
]
```

<h3 id="post-auth-detail">POST /api/Vehicle</h3>

**REQUISIÇÃO**
```json
{
  "description": "O hatch elétrico com melhor custo-benefício da categoria.",
  "brand": 6,
  "model": "Dolphin",
  "optional": "",
  "price": 0
}
```

**RESPOSTA**
```json
{
  "id": "54265acd-00a6-454a-8e19-f7b1d0c88d16",
  "description": "O hatch elétrico com melhor custo-benefício da categoria.",
  "brand": 6,
  "model": "Dolphin",
  "optional": "",
  "price": 0
}
```

<h3 id="put-auth-detail">PUT /api/Vehicle/{id}</h3>

**REQUISIÇÃO**

```json
{
  "description": "O hatch elétrico com melhor custo-benefício da categoria.",
  "brand": 6,
  "model": "BYD Dolphin",
  "optional": "",
  "price": 0
}
```

**RESPOSTA**
```json
{
  "id": "54265acd-00a6-454a-8e19-f7b1d0c88d16",
  "description": "O hatch elétrico com melhor custo-benefício da categoria.",
  "brand": 6,
  "model": "BYD Dolphin",
  "optional": "",
  "price": 0
}
```
