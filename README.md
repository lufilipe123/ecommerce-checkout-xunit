# Ecommerce Checkout

Serviço de pedidos em .NET 10.

## Métodos

- `GerarCodigoRastreio`: formata a região e o número do pedido.
- `CalcularPontosFidelidade`: calcula 2 pontos por cada 10 unidades.
- `TemDireitoAFreteGratis`: concede frete grátis para compras a partir de 200 ou clientes VIP.

## Testes

Execute na raiz do projeto:

```bash
dotnet test
```

Os testes usam xUnit. O teste atual é um exemplo sem asserções; os métodos ainda não têm cobertura funcional.

**Desenvolvedor:** Luiz Filipe
