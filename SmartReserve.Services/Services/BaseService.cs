using AutoMapper;
using FluentValidation;
using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baserepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baserepository = baseRepository;
            _mapper = mapper;
        }
        public void AttachObject(object obj)
        {
            _baserepository.AttachObject(obj);
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baserepository.Insert(entity);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public void Delete(int id)
        {
            _baserepository.Delete(id);
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string>? includes = null) where TOutputModel : class
        {
            var entities = _baserepository.Select(includes);
            var outputModel = entities.Select(s => _mapper.Map<TOutputModel>(s));
            return outputModel;
        }

        public TOutputModel GetById<TOutputModel>(int id, IList<string>? includes = null) where TOutputModel : class
        {
            var entity = _baserepository.Select(id, includes);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baserepository.Update(entity);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
            {
                throw new Exception("Objeto Invalido");
            }
            validator.ValidateAndThrow(obj);
        }
    }
}
