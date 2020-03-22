using Agencia.Domain.Agencia.ValueObjects;
using AutoMapper;
using Ctdig.API.Models.Agencia;
using Ctdig.API.Models.Movimentacoes.Depositos;
using Ctdig.API.Models.Movimentacoes.Movimentacoes;
using Ctdig.API.Models.Movimentacoes.Transferencias;
using Clientes.Domain.Clientes;
using Clientes.Domain.Contas;
using Movimentacoes.Domain.Depositos;
using Movimentacoes.Domain.Movimentacoes;
using Movimentacoes.Domain.Transferencias;

namespace Ctdig.API.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            MapearContextoAgencia();
            MapearContextoClientes();
            MapearContextoMovimentacoes();
        }

        private void MapearContextoAgencia()
        {
            CreateMap<Agencia.Domain.Agencia.Agencia, AgenciaViewModel>();
            CreateMap<DadosBancarios, DadosBancariosViewModel>();
        }

        private void MapearContextoClientes()
        {
            CreateMap<Cliente, Models.Clientes.Clientes.ClienteViewModel>();
            CreateMap<Conta, Models.Clientes.Contas.ContaViewModel>();
        }

        private void MapearContextoMovimentacoes()
        {
            CreateMap<Transferencia, TransferenciaViewModel>();
            CreateMap<Deposito, DepositoViewModel>();
            CreateMap<Movimentacao, MovimentacaoViewModel>();
        }
    }
}
