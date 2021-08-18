using Microsoft.AspNetCore.Mvc;
using Quitanda.API.Controllers.Base;
using Quitanda.CrossCutting.DTO.Fruta;
using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Quitanda.API.Controllers
{
    [Route("api/v1/fruta")]
    public class FrutaController : BaseController<Fruta,FrutaFilter,FrutaDTO, FrutaInsertDTO,FrutaUpdateDTO>
    {
        public FrutaController(IFrutaService frutaService) : base(frutaService)
        {

        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult GetAll(string term)
        {
            var filter = new FrutaFilter(term);
            return GetAll(filter);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Get(Guid id)
        {
            return Find(id);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]       
        public new ActionResult Add([FromBody] FrutaInsertDTO model)
        {
            return base.Add(model);
        }

        //[HttpPut("{id}")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //[ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]        
        //public new ActionResult Update([FromRoute] Guid id, [FromBody] FrutaUpdateDTO model)
        //{
        //    return base.Update(id, model);
        //}

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]      
        public new ActionResult Delete(Guid id)
        {
            return base.Delete(id);
        }

        [HttpPost("/compra")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult Comprar( Guid id, int quantidade)
        {
            var result = ((IFrutaService)_service).Comprar(id, quantidade);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
