using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using Quitanda.Repository.Base;
using Quitanda.Repository.Context;
using Quitanda.Repository.Interface;
using Quitanda.Repository.Mock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quitanda.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario, UsuariosFilter>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context)
        {
        }

        public override List<Usuario> GetAll(UsuariosFilter filter)
        {
            var listUsuarios = MockHelper.GetUsuarios().Where(w => w.Active).ToList();

            if (!string.IsNullOrWhiteSpace(filter.Term))
                listUsuarios = listUsuarios.Where(w => w.Nome.ToUpper().Contains(filter.Term)).ToList();

            return listUsuarios.OrderBy(a => a.Nome).ToList();
        }

        public override Usuario Find(Guid id)
        {
            return MockHelper.GetUsuarios().Where(w => w.Id == id).FirstOrDefault();
        }

        public override void Remove(Guid id)
        {
            var usuario = MockHelper.GetFrutas().Where(w => w.Id == id && w.Active).FirstOrDefault();
            if (usuario != null)
            {
                usuario.Active = false;
            }
        }

        public override Usuario Update(Usuario dto)
        {
            return base.Update(dto);
        }

        public override Guid Create(Usuario dto)
        {
            dto.Id = Guid.NewGuid();

            var usuarios = MockHelper.GetUsuarios().Where(w => w.Active).ToList();

            usuarios.Add(dto);

            return usuarios.LastOrDefault().Id;
        }
    }
}