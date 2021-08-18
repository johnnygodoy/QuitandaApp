using Microsoft.AspNetCore.Mvc;
using Quitanda.API.Controllers.Base;
using Quitanda.CrossCutting.DTO.Usuario;
using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using Quitanda.Services.Interface.Base;
using System;
using System.Net;

namespace Quitanda.API.Controllers
{
    [Route("api/v1/usuario")]
    public class UsuarioController : BaseController<Usuario, UsuariosFilter, UsuarioDTO, UsuarioInsertDTO, UsuarioUpdateDTO>
    {
        public UsuarioController(IUsuarioService usuarioService) : base(usuarioService)
        {
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult GetAll(string term)
        {
            var filter = new UsuariosFilter(term);
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
        public new ActionResult Add([FromBody] UsuarioInsertDTO model)
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
    }
}