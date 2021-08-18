using Microsoft.AspNetCore.Mvc;
using Quitanda.CrossCutting.Base;
using Quitanda.CrossCutting.DTO.Base;
using Quitanda.CrossCutting.Exceptions;
using Quitanda.CrossCutting.Helper;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quitanda.API.Controllers.Base
{
    public class BaseController<T, TFilter, TDto, TInsertDto, TUpdateDto> : ControllerBase where T : class where TFilter : BaseFilter where TDto : class where TInsertDto : class where TUpdateDto : BaseDTO
    {
        protected readonly IBaseService<T, TFilter> _service;

        public BaseController(IBaseService<T, TFilter> baseService)
        {
            _service = baseService;
        }

        protected ActionResult Add(TInsertDto dto)
        {
            if (!ModelState.IsValid)
                throw new EntityValidationException();               

            var entity = MapperHelper.Map<TInsertDto, T>(dto);
            var response = _service.Create(entity);

            return Ok(response);
        }

        protected ActionResult Update(Guid id, TUpdateDto dto)
        {
            if (!ModelState.IsValid)
                throw new EntityValidationException();              

            dto.Id = id;
            var entity = MapperHelper.Map<TUpdateDto, T>(dto);
            var response = _service.Update(entity);

            return Ok(response);
        }

        protected ActionResult Delete(Guid id)
        {
            _service.Remove(id);
            return Ok();
        }

        protected ActionResult Find(Guid id)
        {
            var response = _service.Find(id);

            if (response == null)
                return NotFound();

            return Ok(MapperHelper.Map<T, TDto>(response));
        }

        protected ActionResult GetAll(TFilter filter)
        {
            var response = _service.GetAll(filter);
            return response.Any() ? Ok(MapperHelper.Map<List<T>, List<TDto>>(response)) : throw new NotFoundException();
        }
    }
}
