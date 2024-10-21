using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PublisherService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponsePublisherDto> AddPublisherAsync(AddPublisherDto addPublisherDto)
        {
            var publisher = _mapper.Map<Publisher>(addPublisherDto);
            await _unitOfWork.PublisherRepository.AddAsync(publisher);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<ResponsePublisherDto>(publisher);
        }

        public async Task<ResponsePublisherDto> GetPublisherByIdAsync(int id)
        {
            var publisher = await _unitOfWork.PublisherRepository.GetByIdAsync(id);
            if (publisher == null)
                throw new NotFoundException("Publisher not found", id);
            return _mapper.Map<ResponsePublisherDto>(publisher);
        }

        public async Task DeletePublisherAsync(int id)
        {
            var publisher = await _unitOfWork.PublisherRepository.GetByIdAsync(id);
            if (publisher == null)
                throw new NotFoundException("Publisher not found", id);
            _unitOfWork.PublisherRepository.Delete(publisher);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ResponsePublisherDto> UpdatePublisherAsync(int id, AddPublisherDto updatePublisherDto)
        {
            var publisher = await _unitOfWork.PublisherRepository.GetByIdAsync(id);
            if (publisher == null)
                throw new NotFoundException("Publisher not found", id);

            _mapper.Map(updatePublisherDto, publisher);
            _unitOfWork.PublisherRepository.Update(publisher);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<ResponsePublisherDto>(publisher);
        }

        public async Task<IEnumerable<ResponsePublisherDto>> GetAllPublishersAsync()
        {
            var publishers = await _unitOfWork.PublisherRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ResponsePublisherDto>>(publishers);
        }
    }
}