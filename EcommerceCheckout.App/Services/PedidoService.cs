using System;

namespace EcommerceCheckout.App.Services
{
    public class PedidoService
    {
        public string GerarCodigoRastreio(string regiao, int numeroPedido)
        {
            if (string.IsNullOrWhiteSpace(regiao))
                throw new ArgumentException("Região inválida.", nameof(regiao));

            if (numeroPedido < 0)
                throw new ArgumentOutOfRangeException(nameof(numeroPedido));

            return $"{regiao.Trim().ToUpperInvariant()}-{numeroPedido:D4}";
        }

        public int CalcularPontosFidelidade(int valorTotal)
        {
            if (valorTotal < 0)
                throw new ArgumentOutOfRangeException(nameof(valorTotal));

            return (valorTotal / 10) * 2;
        }

        public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
        {
            if (valorTotal < 0)
                throw new ArgumentOutOfRangeException(nameof(valorTotal));

            return valorTotal >= 200 || eClienteVIP;
        }
    }
}