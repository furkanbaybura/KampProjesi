using AutoMapper;
using DTOs;
using Entities;
using KampYeri.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampYeri.DAL.Services.Abstract
{
    public abstract class Service<TEntity, TDto> : IService<TDto> where TDto : BaseDto where TEntity : BaseEntity

        
    {

        protected IMapper _mapper;
        public Repo<TEntity> _repo;

        protected Service(Repo<TEntity> repo)
        {
            _repo = repo;

            MapperConfiguration configuration = new MapperConfiguration(configuration =>
            {
                configuration.CreateMap<TDto, TEntity>().ReverseMap();
            });

            _mapper = configuration.CreateMapper();
        }

        public IMapper Mapper { set { _mapper = value; } }


        public int Add(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Add(entity);
        }

        public int Delete(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Delete(entity);
        }

        public TDto? Get(int id)
        {
            TEntity? entity = _repo.Get(id);
            TDto dto = _mapper.Map<TDto>(entity);
            return dto;

        }

        public IEnumerable<TDto> GetAll()
        {
           IEnumerable<TEntity> entities = _repo.GetAll();
            IEnumerable<TDto> dtos = _mapper.Map<IEnumerable<TDto>>(entities);
            return dtos;
        }

        public int Update(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Update(entity);
        }
    }
}
