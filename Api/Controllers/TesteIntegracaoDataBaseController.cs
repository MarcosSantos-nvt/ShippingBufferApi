using Domain.Dtos;
using Domain.Interfaces.Test;
using Havan.Logistica.Core.Controller;
using Havan.Logistica.Core.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("entrada")]
    [ApiController]
    public class TesteIntegracaoDataBaseController : MainController
    {
        private readonly IWamasRepositoryTest _wamasRepositoryTest;
        private readonly IItlSysRepositoryTest _tlSysRepositoryTest;
        public TesteIntegracaoDataBaseController(INotifier notifier, IWamasRepositoryTest wamasRepositoryTest, IItlSysRepositoryTest tlSysRepositoryTest) : base(notifier)
        {
            _wamasRepositoryTest = wamasRepositoryTest;
            _tlSysRepositoryTest = tlSysRepositoryTest; 
        }

        [HttpGet, Route("testabase-wamas-efcore")]
        public IActionResult TestaBaseWamasEFCore()
        {
            try
            {
                return Response(_wamasRepositoryTest.TestaWamas_HavanDbConn_EFCore());
            }
            catch (Exception e)
            {
                Notify(e.InnerException?.Message ?? e.Message);
                return Response();
            }
        }

        [HttpGet, Route("testabase-itlsys-efcore")]
        public IActionResult TestaBaseItlSysEFCore()
        {
            try
            {
                return Response(_tlSysRepositoryTest.TestaItlSysDbConn_EFCore());
            }
            catch (Exception e)
            {
                Notify(e.InnerException?.Message ?? e.Message);
                return Response();
            }
        }

        [HttpGet, Route("testabase-wamas-dapper")]
        public IActionResult TestaBaseWamasDapper()
        {
            try
            {
                return Response(_wamasRepositoryTest.TestaWamas_HavanDbConn_Dapper());
            }
            catch (Exception e)
            {
                Notify(e.InnerException?.Message ?? e.Message);
                return Response();
            }
        }

        [HttpGet, Route("testabase-itlsys-dapper")]
        public IActionResult TestaBaseItlSysDapper()
        {
            try
            {
                return Response(_tlSysRepositoryTest.TestaItlSysDbConn_Dapper());
            }
            catch (Exception e)
            {
                Notify(e.InnerException?.Message ?? e.Message);
                return Response();
            }
        }

        //TESTE DE REQUISIÇÃO WORKER => API 

        [HttpPost, Route("unidade-movimentacao")]
        public IActionResult IntegrarUnidadeMovimentacao([FromBody] UnidadeMovimentacaoEntradaDto unidadeMovimentacaoEntradaDto)
        {
            try
            {
                return Response();    
            }

            catch (Exception e)
            {
                Notify(e.InnerException?.Message ?? e.Message);
                return Response();
            }
        }
    }
}
